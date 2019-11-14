using System;
using System.Collections.Generic;
using System.Text;
using Arena_Fighter.Data;


namespace Arena_Fighter.Model
{
    public class Character
    {
        public readonly int characterId;
        public readonly string fullName;
        public int healthpoints;
        public int strength;
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (value.Length > 0 && value.Length < 60 && value != null)
                {
                    firstName = value;
                    // Implementera för nytt namn om tomt / null
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (value.Length > 0 && value.Length < 60 && value != null)
                {
                    lastName = value;
                    // Implementera för nytt namn om tomt / null
                }
            }
        }

        public Character(string firstName, string lastName)
        {
            characterId = IdSequencer.NextId("character");
            FirstName = firstName;
            LastName = lastName;
            fullName = $"{firstName} {lastName}";
            healthpoints = 20;
            strength = 1;
        }
        // Ny constructor för npc
    }
}
