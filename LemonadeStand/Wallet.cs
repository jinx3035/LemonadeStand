using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        public decimal walletBalance = 20.00M;
        public Wallet()
        {

        }

    public void showWalletBalance()
        {
            Console.WriteLine(walletBalance);
        }
    }
}
