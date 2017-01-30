using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        public decimal WalletBalance = 20.00M;


    public void ShowWalletBalance()
        {
            Console.WriteLine(WalletBalance);
        }
    public void AddWalletBalance(decimal amount)
        {

        }
    public bool CheckBalance(decimal amount)
        {
            if(amount <= WalletBalance)
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
