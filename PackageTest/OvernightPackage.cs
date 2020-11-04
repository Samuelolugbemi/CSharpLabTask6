using System;
namespace PackageTest
{
    public class OvernightPackage : Package
    {
        private double packageSizeInKg;
        private decimal costPerKg;
        private  string PackageType {get; set;}
        public OvernightPackage(string firstNameOfSender, string lastNameOfSender, string addressOfSender, string firstNameOfRecipient, string lastNameOfRecipient, string addressOfRecipient, double packageSizeInKg, decimal costPerKg, string packageType) : base(firstNameOfSender, lastNameOfSender, addressOfSender, firstNameOfRecipient, lastNameOfRecipient, addressOfRecipient)
        {
            PackageSizeInKg = packageSizeInKg;
            CostPerKg = costPerKg;
            PackageType = packageType;
        }

        public double PackageSizeInKg
        {
            get{return packageSizeInKg;}
            set{
                if(value > 0){
                    packageSizeInKg = value;
                }
                else{
                    throw new ArgumentOutOfRangeException("Package Size" ,value, "Must be greater than zero");
                }
            }
        }
        public decimal CostPerKg
        {
            get{return costPerKg;}
            set{
                if(value > 0){
                    costPerKg = value;
                }
                else{
                    throw new ArgumentOutOfRangeException("Cost Per Kg" ,value, "Must be greater than zero");
                }
            }
        }

        public override decimal CalculateCost()
        {
            return (decimal)PackageSizeInKg * CostPerKg;
        }

        public override string ToString()
        {
            return $"{PackageType} {base.ToString()}\nSize Of Package: {PackageSizeInKg}kg\nCost Per Kg: {CostPerKg:C}";
        }
    }
}