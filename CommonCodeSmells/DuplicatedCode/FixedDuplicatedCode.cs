
namespace CommonCodeSmells.DuplicatedCode
{
    class DuplicatedCode
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            // Some logic 
            // ...

            var tuple = Time.Parse(admissionDateTime);

            // Some more logic 
            // ...
            if (tuple.Hours < 10)
            {

            }
        }

        public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
        {
            // Some logic 
            // ...

            var tuple = Time.Parse(admissionDateTime);

            // Some more logic 
            // ...
            if (tuple.Hours < 10)
            {

            }
        }
    }
}
