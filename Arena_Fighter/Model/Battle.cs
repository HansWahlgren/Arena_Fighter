using System;
using System.Collections.Generic;
using System.Text;
using Arena_Fighter.Data;

namespace Arena_Fighter.Model
{
    public class Battle
    {
        public readonly int battleId;
        private static Round[] roundArray = new Round[0];
        private Character opponentCharacter;
        private Character playerCharacter;


        public Battle(int battleId, Character playerCharacter, Character opponentCharacter)
        {
            //Characters from character Array
            this.battleId = battleId;
            this.playerCharacter = playerCharacter;
            this.opponentCharacter = opponentCharacter;


        }
    }
}
