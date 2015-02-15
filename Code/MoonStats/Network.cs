using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace MoonStats
{
    public class Network
    {
        public const String POOL_STATUS = "getpoolstatus";
        public const String USER_BALANCE = "getuserbalance";
        public const String USER_STATUS = "getuserstatus";
        public const String USER_WORKERS = "getuserworkers";
        public const String USER_TRANSACTIONS = "getusertransactions";

        private static String generateLink(String action, String url, String apiKey)
        {
            return "https://" + url + "/index.php?page=api&action=" + action + "&api_key=" + apiKey;
        }


        public static JToken getPoolToken(String action, String url, String apiKey)
        {
            String link = generateLink(action, url, apiKey);
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                String json;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    json = reader.ReadToEnd();
                    reader.Close();
                }
                response.Close();

                JObject jObject = JObject.Parse(json);
                return jObject[action]["data"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }

        public static String getDogecoinBalance(String address)
        {
            String link = "https://" + "dogechain.info/chain/CHAIN/q/addressbalance/" + address;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                String balance;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    balance = reader.ReadToEnd();
                    reader.Close();
                }
                response.Close();

                return balance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            
        }

        public static double getDogeValue()
        {
            String sDogeToBtc = "http://" + "www.cryptocoincharts.info/v2/api/tradingPair/doge_btc";
            String sBtcToUsd =  "http://" + "www.cryptocoincharts.info/v2/api/tradingPair/btc_usd";

            double dDogeToBtc, dBtcToUsd;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sDogeToBtc);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                String json;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    json = reader.ReadToEnd();
                    reader.Close();
                }
                response.Close();

                JObject jObject = JObject.Parse(json);  
                dDogeToBtc = Convert.ToDouble(jObject["price"]);



                request = (HttpWebRequest)WebRequest.Create(sBtcToUsd);
                response = (HttpWebResponse)request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    json = reader.ReadToEnd();
                    reader.Close();
                }
                response.Close();

                jObject = JObject.Parse(json);
                dBtcToUsd = Convert.ToDouble(jObject["price"]);

                return dDogeToBtc * dBtcToUsd;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0d;
            }
        }
    }
}
