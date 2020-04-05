using System.Collections.Generic;
using CleanCode.Comments;

namespace CleanCode.OutputParameters
{
    public class GetCustomerResults
    {
        public IEnumerable<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }
}