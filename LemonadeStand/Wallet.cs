using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public decimal walletBalance = 20.00M;

    public void ShowWalletBalance()
        {
            Console.WriteLine(walletBalance);
        }

    public void AddWalletBalance(decimal amount)
        {

        }

    public bool CheckBalance(decimal amount)
        {
            if(amount <= walletBalance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
