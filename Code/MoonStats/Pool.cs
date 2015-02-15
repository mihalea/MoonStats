using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonStats
{
    public class Pool
    {
        public String name { get; set; }
        public String url { get; set;}
        public String key { get; set; }
        public int refreshRate { get; set; }

        public Pool() {
            name = url = key = String.Empty;
            refreshRate = -1;
        }

        public Pool(String name, String url, String key, int refreshRate, List<Wallet> wallets)
        {
            this.name = name;
            this.url = url;
            this.key = key;
            this.refreshRate = refreshRate;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
