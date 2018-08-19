using System;
using System.Linq;

namespace EntityFameworkPart3DatabaseFirst
{
    class Program
    {
        
        static void Main(string[] args)
        {
            QUARKSEntities ctx = new QUARKSEntities();

            //var quarksQuery = from c in ctx.CUSTOMERS
            //                  join t in  ctx.TRANSACTIONS
            //                  on c.CUSTOMER_ID equals t.CUSTOMER_ID
            //                  where c.MIDDLE_NAME != null
            //                  select new
            //                  {
            //                      c.FIRST_NAME,
            //                      c.MIDDLE_NAME,
            //                      c.LAST_NAME,
            //                      t.TRANSACTION_AMOUNT,
            //                      t.TRANSACTION_ID
            //                  };

            //foreach (var result in quarksQuery)
            //{
            //    Console.WriteLine("Customer " + result.FIRST_NAME + " " +
            //        result.MIDDLE_NAME + " " + result.LAST_NAME + " owes "
            //        + result.TRANSACTION_AMOUNT + " for transaction " + result.TRANSACTION_ID);
            //}

            Console.Write("Enter ID of customer: ");
            var CustID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first name of customer: ");
            var FirstName = Console.ReadLine();

            Console.Write("Enter middle name of customer: ");
            var MiddleName = Console.ReadLine();

            Console.Write("Enter last name of customer: ");
            var LastName = Console.ReadLine();

            using (ctx)
            {
                CUSTOMER cust = new CUSTOMER
                {
                    CUSTOMER_ID = CustID,
                    FIRST_NAME = FirstName,
                    MIDDLE_NAME = MiddleName,
                    LAST_NAME = LastName
                };

                ctx.CUSTOMERS.Add(cust);
                ctx.SaveChanges();
            }
        }
    }
}
