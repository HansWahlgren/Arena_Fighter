using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Arena_Fighter.Model;
using Arena_Fighter.Data;

namespace XUnitTest_Arena_Fighter
{
    public class UnitTest_Round
    {
        [Fact]
        public void CreateRoundOk()
        {
            //Arrange
            Character testPlayer = new Character(IdSequencer.NextId("character"), "Phill", "Wahlgreno");
            Character testOpponent = new Character(IdSequencer.NextId("character"));
            testPlayer.strength += 8;

            //Act
            new Round(testPlayer, testOpponent);
            new Round(testPlayer, testOpponent);
            Round thirdRound = new Round(testPlayer, testOpponent);
            Round fourthRound = new Round(testPlayer, testOpponent);

            //Assert
            Assert.Equal(fourthRound.roundId -1, thirdRound.roundId);
            Assert.NotSame(testPlayer, testOpponent);
            Assert.True(testPlayer.isAlive);
            Assert.False(testOpponent.isAlive);
        }
    }
}
