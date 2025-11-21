using System;

namespace Lyserra.PlayerAndAttributes
{
    public class Pet
    {

        private string ownerName;
        private string petName;
        private short petWeight;
        private byte petAge;

        public string PetName { get { return ownerName; } set { ownerName = value; } }
        public string OwnerName { get { return petName; } set { petName = value; } }
        public short PetWeight { get { return petWeight; } set { petWeight = value; } }
        public byte PetAge { get { return petAge; } set { petAge = value; } }

        public Pet(string ownerName, string petName, short petWeight, byte petAge)
        {
            this.ownerName = ownerName;
            this.petName = petName;
            this.petWeight = petWeight;
            this.petAge = petAge;
        }


    }
}
