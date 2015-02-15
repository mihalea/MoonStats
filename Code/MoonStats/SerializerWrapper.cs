using System;
using System.Collections.Generic;
using System.ComponentModel;





namespace MoonStats
{
    public class SerializerWrapper
    {
        public List<Pool> Pools { get; set; }
        public BindingList<Wallet> Wallets { get; set; }
        public List<Transaction> Transactions { get; set; }
        public String LastUsed { get; set; }
    }
}
