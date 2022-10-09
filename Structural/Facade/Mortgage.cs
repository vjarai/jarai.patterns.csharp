using System;

namespace Jarai.Patterns.Structural.Facade
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>

    public class Mortgage
    {
        readonly Bank _bank = new Bank();
        readonly Loan _loan = new Loan();
        readonly Credit _credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                cust.Name, amount);

            var eligible = true;

            // Check creditworthyness of applicant

            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}