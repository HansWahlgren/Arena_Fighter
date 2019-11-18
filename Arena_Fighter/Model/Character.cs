using System;
using System.Collections.Generic;
using System.Text;
using Lexicon.CSharp.InfoGenerator;
using Arena_Fighter.Data;


namespace Arena_Fighter.Model
{
    public class Character
    {
        static readonly InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);
        public readonly int characterId;
        public readonly string fullName;
        public bool isAlive;
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
                }
                else
                {
                    firstName = infoGen.NextFirstName();
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
                    
                }
                else
                {
                    lastName = infoGen.NextLastName();
                }
            }
        }
        
        public Character(int characterId)
        {
            this.characterId = characterId;
            isAlive = true;
            healthpoints = 20;
            strength = 1;
            FirstName = "";
            LastName = "";
            fullName = $"{firstName} {lastName}";
        }

        public Character(int characterId, string firstName, string lastName)
        : this(characterId) {
            FirstName = firstName;
            LastName = lastName;
            fullName = $"{firstName} {lastName}";
        }
        
    }
}
