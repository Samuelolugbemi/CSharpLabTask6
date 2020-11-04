using System;
namespace PackageTest
{
    public abstract class Package
    {
        private string FirstNameOfSender{get; set;}

        private string LastNameOfSender{get; set;}
        private string AddressOfSender{get; set;}
        private string FirstNameOfRecipient{get; set;}
        private string LastNameOfRecipient{get; set;}
        private string AddressOfRecipient{get; set;}

        public Package(string firstNameOfSender, string lastNameOfSender, string addressOfSender, string firstNameOfRecipient, string lastNameOfRecipient, string addressOfRecipient)
        {
            FirstNameOfSender = firstNameOfSender;
            LastNameOfSender = lastNameOfSender;
            AddressOfSender = addressOfSender;
            FirstNameOfRecipient = firstNameOfRecipient;
            LastNameOfRecipient = lastNameOfRecipient;
            AddressOfRecipient = addressOfRecipient;
        }

        public abstract decimal CalculateCost();
        public override string ToString()
        {
            return $"Adress Information\nSenderName: {FirstNameOfSender} {LastNameOfSender}\nSenderAddress: {AddressOfSender}\nRecipientName: {FirstNameOfRecipient} {LastNameOfRecipient}\nRecipient Adress: {AddressOfRecipient}";
        }

    }
}