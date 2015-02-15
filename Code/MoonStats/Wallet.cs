using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonStats
{
    public class Wallet
    {
        public String Label { get; set; }
        public String Address { get; set; }
        public double Balance { get; set; }

        public Wallet()
        {
            Label = Address = String.Empty;
            Balance = 0d;
        }

        public Wallet(String name, String address, double balance)
        {
            this.Label = name;
            this.Address = address;
            this.Balance = balance;
        }

        public override bool Equals(object obj)
        {
            if(obj is Wallet == false)
                return false;

            Wallet w = (Wallet) obj;
            return Address.Equals(w.Address);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
            
    }
}
