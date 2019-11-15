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

            int characterNewestId;
            int roundNewestId;
            int battleNewestId;

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

            characterNewestId = IdSequencer.NextId("character");
            roundNewestId = IdSequencer.NextId("round");
            battleNewestId = IdSequencer.NextId("battle");
         
            //Assert
            Assert.Equal(characterNewestId - 1, characterId);
            Assert.Equal(roundNewestId - 1, roundId);
            Assert.Equal(battleNewestId - 1, battleId);
        }

        [Fact]
        public void ResetIdOk()
        {
            //Arrange
            int characterId;
            int roundId;
            int battleId;

            //Act
            for (int i = 0; i < 10; i++)
            {
                IdSequencer.NextId("character");
                IdSequencer.NextId("round");
            }
            for (int i = 0; i < 5; i++)
            {
                IdSequencer.NextId("round");
                IdSequencer.NextId("battle");
            }

            IdSequencer.ResetId("round");
            IdSequencer.ResetId("character");
            IdSequencer.ResetId("battle");
            characterId = IdSequencer.NextId("character");
            roundId = IdSequencer.NextId("round");
            battleId = IdSequencer.NextId("battle");

            //Assert
            Assert.Equal(1, characterId);
            Assert.Equal(1, roundId);
            Assert.Equal(1, battleId);
        }
    }
}
