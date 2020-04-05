using System;

namespace CommonCodeSmells.SwitchStatements
{
    public class MonthlyUsage
    {
        public Customer Customer { get; set; }
        public int CallMinutes { get; set; }
        public int SmsCount { get; set; }

        public void Generate(MonthlyStatement monthlyStatement)
        {
            switch (this.Customer.Type)
            {
                case CustomerType.PayAsYouGo:
                    monthlyStatement.CallCost = 0.12f * this.CallMinutes;
                    monthlyStatement.SmsCost = 0.12f * this.SmsCount;
                    monthlyStatement.TotalCost = monthlyStatement.CallCost + monthlyStatement.SmsCost;
                    break;

                case CustomerType.Unlimited:
                    monthlyStatement.TotalCost = 54.90f;
                    break;

                default:
                    throw new NotSupportedException("The current customer type is not supported");
            }
        }

      
    }
}