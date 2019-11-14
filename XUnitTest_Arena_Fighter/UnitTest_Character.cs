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
     //   static readonly InfoGenerator infoGen = new InfoGenerator(DateTime.Now.Millisecond);

        [Fact]
        public void CreateCharacterOk()
        {
            //Arrange
            Character character1 = new Character("Jon", "Snow");
            Character character2 = new Character("Grom", "Hellscream");
            Character character3 = new Character("Frodo", "Baggings");

            //Act
            character1.healthpoints += 5;
            character2.strength += 2;

            //Assert
            Assert.Equal("Jon Snow", character1.fullName);
            Assert.Equal(25, character1.healthpoints);
            Assert.Equal(3, character2.strength);
            Assert.Equal(3, character3.characterId);
        }
    }
}
