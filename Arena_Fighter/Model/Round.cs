using System;
using System.Collections.Generic;
using System.Text;
using Arena_Fighter.Data;

namespace Arena_Fighter.Model
{
    public class Round
    {
        static readonly Random random = new Random();
        public readonly int roundId;
        public Character playerCharacter;
        public Character opponentCharacter;
        public readonly int playerDieRoll;
        public readonly int opponentDieRoll;
        public readonly int playerStr;
        public readonly int opponentStr;

        public int DamageDealt { get; private set; }

        public Round(Character playerCharacter, Character opponentCharacter)
        {
            roundId = IdSequencer.NextId("round");
            this.playerCharacter = playerCharacter;
            this.opponentCharacter = opponentCharacter;
            playerDieRoll = random.Next(1, 6);
            opponentDieRoll = random.Next(1, 6);
            playerStr = playerDieRoll + playerCharacter.strength;
            opponentStr = opponentDieRoll + opponentCharacter.strength;
            CheckDamage(playerStr, opponentStr);
        }

        private void CheckDamage(int playerStr, int opponentStr)
        {
            DamageDealt = 0;
            if (playerStr > opponentStr)
            {
                TakesDamage(opponentCharacter, playerStr, opponentStr);
            }
            else if(playerStr < opponentStr)
            {
                TakesDamage(playerCharacter, opponentStr, playerStr);
            }
        }

        private void TakesDamage(Character defeatedCharacter, int winnerStr, int loserStr)
        {
            DamageDealt = (2 + winnerStr) - loserStr;
            defeatedCharacter.healthpoints -= DamageDealt;
            if(defeatedCharacter.healthpoints <= 0)
            {
                defeatedCharacter.isAlive = false;
            }
        }
    }
}
