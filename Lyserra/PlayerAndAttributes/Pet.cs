using System;

namespace Lyserra.PlayerAndAttributes
{
    public abstract class Pet
    {

        private string petName;
        private short petWeight;
        private byte petAge;

        public Pet(string petName, short petWeight, byte petAge)
        {
            this.petName = petName;
            this.petWeight = petWeight;
            this.petAge = petAge;
        }

        public string PetName { get { return petName; } set { petName = value; } }
        public short PetWeight { get { return petWeight; } set { petWeight = value; } }
        public byte PetAge { get { return petAge; } set { petAge = value; } }

        public string Name { get; set; }
        public string Breed { get; set; }
        public string HairColor { get; set; }
        public string HairCut { get; set; }
        public string EyeType { get; set; }
        public string EyeColor { get; set; }
        public string SpecialEye { get; set; }
        public string Accessory { get; set; }
        public string Personality { get; set; }
        public string Scent { get; set; }
        public string Mutation { get; set; }

        public abstract string showDisplay();


    }
}
