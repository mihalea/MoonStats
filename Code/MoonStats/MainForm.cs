using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace MoonStats
{
    public partial class MoonStats : Form 
    {
        private const String version = "1.0";
        private const String localFile = "data.xml";

        private Pool selectedPool;
        private String lastUsed;

        private List<Pool> pools;
        private List<Transaction> transactions;
        private BindingList<Wallet> wallets;

        private bool monitoring = false;

        private BindingSource source = new BindingSource();

        private double doge, usd;
        private double exchange;
       

        public MoonStats()
        {
            InitializeComponent();
            initialise();
        }

        private void initialise()
        {
            pools = new List<Pool>();
            wallets = new BindingList<Wallet>();
            transactions = new List<Transaction>();
        }

        private void writeXML<T>(T obj, String file)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            using (TextWriter writer = new StreamWriter(file))
            {
                serializer.Serialize(writer, obj);
            }
        }

        private Object readXML(Type t, String file)
        {
            XmlSerializer deserializer = new XmlSerializer(t);
            Object result;
            using (TextReader reader = new StreamReader(file))
            {
                result = deserializer.Deserialize(reader);
            }
            return result;
        }

        private bool isValidAddres(String address)
        {
            if (address == null || String.IsNullOrWhiteSpace(address))
                return false;

            if (address.ToCharArray().ElementAt(0) != 'D')
                return false;

            if (address.Length != 34)
                return false;

            return true;
        }

        private void loadWallets()
        {
            source.DataSource = null;
            source.DataSource = wallets;
            dgvWallet.DataSource = source;
            setupWalletTable();
        }

        private void loadPools()
        {
            foreach (Pool pool in pools)
            {
                cbxPools.Items.Add(pool);
                if (pool.name.Equals(lastUsed))
                {
                    selectedPool = pool;
                    cbxPools.SelectedItem = pool;
                    updateUiLocked();
                }
            }
        }

        private void setupWalletTable()
        {
            dgvWallet.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvWallet.Columns[1].Width = 75;
            dgvWallet.Columns[2].Width = 75;
            dgvWallet.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void sortWallets()
        {
            SortOrder order = getSortOrder();
            List<Wallet> sorted = wallets.OrderBy(x => x.Balance).ToList();
            if (order == SortOrder.Descending)
                sorted.Reverse();
            wallets = new BindingList<Wallet>(sorted);
            loadWallets();
            dgvWallet.Columns[2].HeaderCell.SortGlyphDirection = order;
        }

        private SortOrder getSortOrder()
        {
            SortOrder order = dgvWallet.Columns[2].HeaderCell.SortGlyphDirection;
            if (order == SortOrder.None || order == SortOrder.Ascending)
            {
                return SortOrder.Descending;
            }
            else
            {
                return SortOrder.Ascending;
            }

        }

        private void toggleMonitor()
        {
            if (monitoring)
            {
                poolTimer.Stop();

                btnStart.Text = "Start monitoring";
                btnStart.ForeColor = Color.Green;

                lbStatus.Text = "Status: Stopped";

                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
                cbxPools.Enabled = true;

                monitoring = !monitoring;
            }
            else
            {
                poolTimer.Interval = selectedPool.refreshRate * 1000;
                poolTimer.Start();

                bgwWallet.RunWorkerAsync();
                bgwPool.RunWorkerAsync();

                btnStart.Text = "Stop monitoring";
                btnStart.ForeColor = Color.Red;

                lbStatus.Text = "Status: Running";

                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                cbxPools.Enabled = false;

                monitoring = !monitoring;
            }
        }

        private void updateUiLocked()
        {
            if (selectedPool == null)
            {
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                btnStart.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
                btnStart.Enabled = true;
            }
        }

        private void updateChart()
        {
            chart1.Series.Clear();
            Series series = new Series
            {
                Name = "Transactions",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            chart1.Series.Add(series);

            int i = 0;
            foreach (Transaction t in transactions){
                if(t.Credit == 0)
                    continue;
                series.Points.AddXY(i++, t.Credit);
            }
        }

        private void MoonStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            bgwWrite.RunWorkerAsync();

            if (monitoring &&
                DialogResult.No == MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo))
                e.Cancel = true;
        }

        private void MoonStats_Load(object sender, EventArgs e)
        {
            bgwRead.RunWorkerAsync();
            bgwExchange.RunWorkerAsync();

            exchangeTimer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PoolManager dialog = new PoolManager(null);
            dialog.ShowDialog();
            Pool pool = dialog.selectedPool;
            if (String.IsNullOrWhiteSpace(pool.key) == false &&
                String.IsNullOrWhiteSpace(pool.name) == false &&
                String.IsNullOrWhiteSpace(pool.url) == false)
            {
                selectedPool = pool;
                cbxPools.Items.Add(selectedPool);
                cbxPools.SelectedItem = selectedPool;
                pools.Add(selectedPool);
            }

            updateUiLocked();
            bgwWrite.RunWorkerAsync();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            PoolManager dialog = new PoolManager(selectedPool);
            dialog.ShowDialog();
            selectedPool = dialog.selectedPool;
            cbxPools.Items.Clear();
            cbxPools.Items.AddRange(pools.ToArray());
            cbxPools.SelectedItem = selectedPool;
            bgwWrite.RunWorkerAsync();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Pool toRemove = selectedPool;
            selectedPool = null;
            cbxPools.Items.Remove(toRemove);
            pools.Remove(toRemove);
            if (pools.Count > 0) {
                selectedPool = pools[0];
                cbxPools.SelectedItem = selectedPool;
            }
            updateUiLocked();
            bgwWrite.RunWorkerAsync();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            toggleMonitor();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bgwPool.RunWorkerAsync();
            bgwWallet.RunWorkerAsync();
        }

        private void exchangeTimer_Tick(object sender, EventArgs e)
        {
            bgwExchange.RunWorkerAsync();
        }

        private void dgvWorkers_SelectionChanged(object sender, EventArgs e)
        {
            dgvWorkers.ClearSelection();
        }

        private void cbxPools_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPool = (Pool) cbxPools.SelectedItem;
            updateUiLocked();
        }

        private void dgvWallet_Leave(object sender, EventArgs e)
        {
            bgwWrite.RunWorkerAsync();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License license = new License();
            license.ShowDialog();
        }

        private void importWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdWallet.ShowDialog();
            if (result != DialogResult.OK)
                return;

            String file = ofdWallet.FileName;
            String[] lines = File.ReadAllLines(file);

            int count = lines.Count();
            for (int i = 1; i < count; i++ )
            {
                String line = lines[i];

                String label, address;
                String[] split = line.Split(',');
                label = split[0];
                address = split[1];

                label = formatWalletCSV(label);
                address = formatWalletCSV(address);

                bool isUnique = true;
                foreach (Wallet wallet in wallets)
                {
                    if (wallet.Address.Equals(address))
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    wallets.Add(new Wallet(label, address, 0));
                }
            }

            loadWallets();
        }

        private String formatWalletCSV(String csv){
            return csv.Substring(1, csv.Length - 2);
        }

        private void bgwExchange_DoWork(object sender, DoWorkEventArgs e)
        {
            exchange = Network.getDogeValue();
        }

        private void bgwWallet_DoWork(object sender, DoWorkEventArgs e)
        {
            double sum = 0;

            foreach (DataGridViewRow row in dgvWallet.Rows)
            {
                String address = (String)row.Cells[1].Value;

                if (isValidAddres(address) == false)
                    continue;

                String balance = Network.getDogecoinBalance(address);
                DataGridViewCell cell = row.Cells[2];
                if (balance == null)
                {
                    cell.Value = "INVALID";
                    cell.Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                }
                else
                {
                    sum += Convert.ToDouble(balance);
                    cell.Value = balance;
                    cell.Style = new DataGridViewCellStyle { ForeColor = Color.Black };
                }
            }

            doge = sum;
            usd = doge * exchange;

            //dgvWallet.Sort(dgvWallet.Columns[2], ListSortDirection.Descending);
        }

        private void bgwPool_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                String url = selectedPool.url;
                String key = selectedPool.key;
                String var;

                //POOL STATUS
                JToken poolStatus = (JToken)Network.getPoolToken(Network.POOL_STATUS, url, key);

                // Network hashrate in GHz
                double netHash = Convert.ToDouble(poolStatus["nethashrate"]);
                netHash = netHash / 1000000000d; // 1000 / 1000 / 1000 
                netHash = Math.Round(netHash, 3);
                var = netHash.ToString() + " GHz/s";
                bgwPool.ReportProgress(0, var);

                Console.WriteLine("Network hashrate: " + var);

                // Pool hashrate
                double poolHash = Convert.ToDouble(poolStatus["hashrate"]);
                poolHash = poolHash / 1000000d; // 1000 / 1000
                poolHash = Math.Round(poolHash, 3);
                var = poolHash.ToString() + " GHz/s";
                bgwPool.ReportProgress(1, var);
                Console.WriteLine("Pool hashrate: " + var);

                // Current network block
                var = (String)poolStatus["currentnetworkblock"];
                bgwPool.ReportProgress(2, var);
                Console.WriteLine("Current network block: " + var);

                // Network difficulty
                String diff = (String)poolStatus["networkdiff"];
                var = Math.Round(Convert.ToDouble(diff), 2).ToString();
                bgwPool.ReportProgress(3, var);
                Console.WriteLine("Network difficulty: " + var);

                // Time to next block
                String timeToRaw = (String)poolStatus["esttime"];
                int timeTo = (int)Convert.ToDouble(timeToRaw);
                TimeSpan timeSpanTo = TimeSpan.FromSeconds(timeTo);
                var = timeSpanTo.Hours + ":" + timeSpanTo.Minutes + ":" + timeSpanTo.Seconds;
                bgwPool.ReportProgress(4, var);
                Console.WriteLine("Time estimated: " + var);

                // Time since last block
                String timeSinceRaw = (String)poolStatus["timesincelast"];
                int timeSince = (int)Convert.ToDouble(timeSinceRaw);
                TimeSpan timeSpanSince = TimeSpan.FromSeconds(timeSince);
                var = timeSpanSince.Hours + ":" + timeSpanSince.Minutes + ":" + timeSpanSince.Seconds;
                bgwPool.ReportProgress(5, var);
                Console.WriteLine("Time since: " + var);



                //USER STATUS
                Thread.Sleep(1000);
                JToken userStatus = Network.getPoolToken(Network.USER_STATUS, url, key);

                // User Hashrate
                var = (String)userStatus["hashrate"] + " MHz/s";
                bgwPool.ReportProgress(6, var);
                Console.WriteLine("User hashrate: " + var);

                // User Sharerate
                var = (String)userStatus["sharerate"];
                bgwPool.ReportProgress(7, var);
                Console.WriteLine("User sharerate: " + var);

                // Valid shares
                var = (String)userStatus["shares"]["valid"];
                bgwPool.ReportProgress(8, var);
                Console.WriteLine("Valid shares: " + var);

                //Invalid shares
                var = (String)userStatus["shares"]["invalid"];
                bgwPool.ReportProgress(9, var);
                Console.WriteLine("Invalid shares: " + var);


                //USER BALANCE
                Thread.Sleep(1000);
                JToken userBalance = Network.getPoolToken(Network.USER_BALANCE, url, key);

                // Confirmed
                double dConfirmed = Convert.ToDouble((String)userBalance["confirmed"]);
                dConfirmed = Math.Round(dConfirmed, 3);
                var = dConfirmed.ToString();
                bgwPool.ReportProgress(10, var);
                Console.WriteLine("Confirmed: " + var);

                // Unconfirmed
                double dUnconfirmed = Convert.ToDouble((String)userBalance["unconfirmed"]);
                dUnconfirmed = Math.Round(dUnconfirmed, 3);
                var = dUnconfirmed.ToString();
                bgwPool.ReportProgress(11, var);
                Console.WriteLine("Unconfirmed: " + var);

                //WORKERS
                Thread.Sleep(1000);
                JToken workers = Network.getPoolToken(Network.USER_WORKERS, url, key);


                BeginInvoke((MethodInvoker)delegate
                {
                    dgvWorkers.Rows.Clear();
                });
                String username = String.Empty;
                foreach (JToken token in workers)
                {
                    String temp = (String)token["username"];
                    String[] values = temp.Split('.');
                    if (username.Equals(String.Empty))
                        username = values[0];

                    BeginInvoke((MethodInvoker)delegate
                    {
                        dgvWorkers.Rows.Add(values[1], (String)token["hashrate"], (String)token["difficulty"]);
                    });
                }


                //USER TRANSACTIONS
                Thread.Sleep(1000);
                JToken userTransactions = Network.getPoolToken(Network.USER_TRANSACTIONS, url, key);

                foreach (JToken token in userTransactions["transactions"])
                {
                    String type = (String)token["type"];
                    double amount = Convert.ToDouble(token["amount"]);
                    String hash = (String)token["blockhash"];

                    if (!type.Equals("Credit") && !type.Equals("Fee"))
                        continue;

                    bool exists = false;
                    foreach (Transaction t in transactions)
                    {
                        if (t.Hash == null)
                            continue;

                        if (t.Hash.Equals(hash))
                        {
                            if (type.Equals("Credit"))
                                t.Credit = amount;
                            else if (type.Equals("Fee"))
                                t.Fee = amount;

                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        Transaction t = new Transaction();
                        t.Hash = hash;
                        if (type.Equals("Credit"))
                            t.Credit = amount;
                        else if (type.Equals("Fee"))
                            t.Fee = amount;

                        transactions.Add(t);
                    }
                }
                double totalMined = 0, totalFee = 0, min = 0, max = 0, avg = 0;

                min = transactions[0].Credit;
                max = min;
                int zero = 0;

                foreach (Transaction t in transactions)
                {
                    totalMined += t.Credit;
                    totalFee += t.Fee;

                    if (t.Credit == 0)
                        zero++;
                    else if (t.Credit < min)
                        min = t.Credit;
                    else if (t.Credit > max)
                        max = t.Credit;
                }

                avg = totalMined / (transactions.Count - zero);

                totalMined = Math.Round(totalMined, 3);
                totalFee = Math.Round(totalFee, 3);
                min = Math.Round(min, 3);
                max = Math.Round(max, 3);
                avg = Math.Round(avg, 3);

                BeginInvoke((MethodInvoker)delegate
                {
                    varTotalMined.Text = totalMined.ToString();
                    varTotalFees.Text = totalFee.ToString();
                    varMin.Text = min.ToString();
                    varMax.Text = max.ToString();
                    varAvg.Text = avg.ToString();
                });


                Console.WriteLine("Total mined: " + totalMined);
                Console.WriteLine("Total fees: " + totalFee);
                Console.WriteLine("Minimum reward: " + min);
                Console.WriteLine("Maximum reward: " + max);
                Console.WriteLine("Average reward: " + avg);


                Console.WriteLine("Successfully downloaded data!");
            }
            catch (Exception ex)
            {
                bgwPool.ReportProgress(100);
                Console.WriteLine(ex.ToString());
            }
        }

        private void bgwWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            String path = Path.GetDirectoryName(Application.ExecutablePath);
            String filePath = path + @"\" + localFile;

            try
            {
                SerializerWrapper wrapper = new SerializerWrapper()
                {
                    Pools = pools,
                    Wallets = wallets,
                    Transactions = transactions,
                    LastUsed = selectedPool.name
                };
                writeXML(wrapper, filePath);
                Console.WriteLine("Successfully saved to disk");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not write to disk");
                Console.WriteLine(ex.ToString());
            }
        }

        private void bgwRead_DoWork(object sender, DoWorkEventArgs e)
        {
            String path = Path.GetDirectoryName(Application.ExecutablePath);
            String filePath = path + @"\" + localFile;
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Local file not found");
                return;
            }
            List<String> list = new List<String>();

            try
            {
                SerializerWrapper wrapper = (SerializerWrapper)readXML(typeof(SerializerWrapper), filePath);
                pools = wrapper.Pools;
                wallets = wrapper.Wallets;
                lastUsed = wrapper.LastUsed;
                transactions = wrapper.Transactions;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not read from disk");
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        private void bgwExchange_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbDogeToUsd.Text = "1 Doge = " + exchange.ToString() + "$";
            Console.WriteLine("Exchange: " + exchange);
            Console.WriteLine("Exchange worker finished");
        }

        private void bgwWallet_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            varDoge.Text = Math.Round(doge, 3).ToString();
            Console.WriteLine("Total doge: " + doge);
            varUsd.Text = Math.Round(usd, 3).ToString();
            Console.WriteLine("Total usd: " + usd);
            Console.WriteLine("Wallet worker finished");
        }

        private void bgwPool_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            updateChart();
            Console.WriteLine("Pool worker finished");
        }

        private void bgwWrite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Write worker finished");
        }

        private void bgwRead_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.loadWallets();
            this.sortWallets();
            this.loadPools();
            Console.WriteLine("Read worker finished");
        }

        private void bgwPool_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0:
                    varNetworkHashrate.Text = (String)e.UserState;
                    break;
                case 1:
                    varPoolHashrate.Text = (String)e.UserState;
                    break;
                case 2:
                    varBlock.Text = (String)e.UserState;
                    break;
                case 3:
                    varDifficulty.Text = (String)e.UserState;
                    break;
                case 4:
                    varTimeTo.Text = (String)e.UserState;
                    break;
                case 5:
                    varTimeSince.Text = (String)e.UserState;
                    break;
                case 6:
                    varUserHashrate.Text = (String)e.UserState;
                    break;
                case 7:
                    varUserSharerate.Text = (String)e.UserState;
                    break;
                case 8:
                    varValid.Text = (String)e.UserState;
                    break;
                case 9:
                    varInvalid.Text = (String)e.UserState;
                    break;
                case 10:
                    varConfirmed.Text = (String)e.UserState;
                    break;
                case 11:
                    varUnconfirmed.Text = (String)e.UserState;
                    break;
                case 100:
                    toggleMonitor();
                    lbStatus.Text = "Status: Errors";
                    break;
            }
        }

        private void dgvWallet_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sortWallets();
        }

        private void dgvWallet_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }
  
    }
}
