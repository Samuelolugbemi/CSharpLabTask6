using System;
namespace PackageTest
{
    public class TwoDayPackage : OvernightPackage
    {
        private  string PackageType = "Two Day Package";
        public TwoDayPackage(string firstNameOfSender, string lastNameOfSender, string addressOfSender, string firstNameOfRecipient, string lastNameOfRecipient, string addressOfRecipient, double packageSizeInKg, decimal costPerKg) : base(firstNameOfSender, lastNameOfSender, addressOfSender, firstNameOfRecipient, lastNameOfRecipient, addressOfRecipient, packageSizeInKg, costPerKg)
        {
            
        }
        public override decimal CalculateCost()
        {
            return base.CalculateCost() * 2;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}