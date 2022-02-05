using System;
namespace BankEncapsulationExercise
{
    public class BankAccount
    {

        private double Balance = 0;

        public BankAccount()
        {
        }

        public void Deposit (double dep)
        {
            Balance += dep;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
