using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lexicon.CSharp.InfoGenerator;
using Arena_Fighter.Model;
using Arena_Fighter.Data;

namespace XUnitTest_Arena_Fighter
{
    public class UnitTest_Character
    {
        [Fact]
        public void CreateCharacterOk()
        {
            //Arrange
            string firstName = "Grom";
            string lastName = "Hellscream";

            //Act
            Character character1 = new Character(IdSequencer.NextId("character"),"", "");
            Character character2 = new Character(IdSequencer.NextId("character"), firstName, lastName);
            Character character3 = new Character(IdSequencer.NextId("character"));

            //Assert
            Assert.Equal(20, character1.healthpoints);
            Assert.Equal("Grom Hellscream", character2.fullName);
            Assert.Equal(1, character2.strength);
            Assert.Equal(3, character3.characterId);
        }
    }
}
