using System;


namespace Lyserra.PlayerAndAttributes
{
    public class Owner
    {
        private string ownerName;

        public Owner(string ownerName)
        {
            this.ownerName = ownerName;
        }

        public string OwnerName { get { return ownerName; } set { ownerName = value; } }

        public string returnName()
        {
            string message = "HI " + ownerName + "! Welcome to Lyserra.";
            return message;
        }
    }
}
