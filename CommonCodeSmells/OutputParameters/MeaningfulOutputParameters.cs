using CleanCode.Comments;
using System;
using System.Collections.Generic;

namespace CleanCode.OutputParameters
{
    public class MeaningfulOutputParameters
    {
        public void DisplayCustomers()
        {
            const int pageIndex = 1;
            var tuple = GetCustomers(pageIndex);

            Console.WriteLine("Total customers: " + tuple.TotalCount);
            foreach (var c in tuple.Customers)
                Console.WriteLine(c);
        }

        public GetCustomerResults GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return new GetCustomerResults()
            {
                TotalCount = totalCount,
                Customers = new List<Customer>()
            };
        }
    }
}
