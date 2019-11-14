using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Arena_Fighter.Model;
using Arena_Fighter.Data;

namespace XUnitTest_Arena_Fighter
{
    public class UnitTest_IdSequencer
    {
        [Fact]
        public void IdcounterOk()
        {
            //Arrange
            int characterId = 0;
            int roundId = 0;
            int battleId = 0;

            //Act
            for (int i = 0; i < 10; i++)
            {
                characterId = IdSequencer.NextId("character");
                roundId = IdSequencer.NextId("round");
            }
            for (int i = 0; i < 5; i++)
            {
                roundId = IdSequencer.NextId("round");
                battleId = IdSequencer.NextId("battle");
            }

            //Assert
            Assert.Equal(10, characterId);
            Assert.Equal(15, roundId);
            Assert.Equal(5, battleId);
        }

        [Fact]
        public void ResetIdOk()
        {
            //Arrange
            int characterId = 0;
            int roundId = 0;
            int battleId = 0;

            //Act
            for (int i = 0; i < 10; i++)
            {
                characterId = IdSequencer.NextId("character");
                roundId = IdSequencer.NextId("round");
            }
            for (int i = 0; i < 5; i++)
            {
                roundId = IdSequencer.NextId("round");
                battleId = IdSequencer.NextId("battle");
            }

            IdSequencer.ResetId("round");
            IdSequencer.ResetId("character");
            characterId = IdSequencer.NextId("character");
            roundId = IdSequencer.NextId("round");

            //Assert
            Assert.Equal(1, characterId);
            Assert.Equal(1, roundId);
            Assert.Equal(5, battleId);
        }
    }
}
