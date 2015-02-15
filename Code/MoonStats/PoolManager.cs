using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonStats
{
    public partial class PoolManager : Form
    {
        public Pool selectedPool { get; set; }

        public PoolManager(Pool pool)
        {
            InitializeComponent();

            if (pool == null)
                selectedPool = new Pool();
            else
                selectedPool = pool;

            populateGui();
        }

        private void populateGui()
        {
            tboxPool.Text = selectedPool.name;
            tboxURL.Text = selectedPool.url;
            tboxKey.Text = selectedPool.key;
            tboxRefresh.Text = selectedPool.refreshRate.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<TextBox> boxes = new List<TextBox>(Controls.OfType<TextBox>());
            bool validates = true;
            foreach (TextBox box in boxes)
                if (String.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider.SetError(box, "Textbox can't be empty");
                    validates = false;
                }

            if(validates)
                this.Close();
        }

        private void tboxURL_TextChanged(object sender, EventArgs e)
        {
            String url = tboxURL.Text;
            selectedPool.url = url;
        }

        private void tboxKey_TextChanged(object sender, EventArgs e)
        {
            String key = tboxKey.Text;
            selectedPool.key = key;
        }

        private void tboxRefresh_TextChanged(object sender, EventArgs e)
        {
            int refreshRate;
            Int32.TryParse(tboxRefresh.Text, out refreshRate);
            selectedPool.refreshRate = refreshRate;
            Validate();
        }

        private void tboxPool_TextChanged(object sender, EventArgs e)
        {
            String pool = tboxPool.Text;
            selectedPool.name = pool;
        }

        private void tboxRefresh_Validating(object sender, CancelEventArgs e)
        {
            int rate = -1;
            Int32.TryParse(tboxRefresh.Text, out rate);
            if (rate < 15)
            {
                errorProvider.SetError(tboxRefresh, "Value must be greater than 15 seconds");
                e.Cancel = true;
            }
        }
    }
}
