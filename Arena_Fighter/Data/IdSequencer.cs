using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_Fighter.Data
{
    public class IdSequencer
    {
        private static int characterId = 0;
        private static int roundId = 0;
        private static int battleId = 0;

        public static int NextId(string objectId)
        {
            /*
            return objectId switch
            {
                "character" => ++characterId,
                "round" => ++roundId,
                "battle" => ++battleId
                 //   _ => 0,
            };
            */
            switch (objectId)
            {
                case "character":
                    return ++characterId;
                case "round":
                    return ++roundId;
                case "battle":
                    return ++battleId;
                default:
                    return 0;
            }
    }

    public static void ResetId(string objectId)
    {
        /*
        objectId switch
        {
            "character" => characterId = 0,
            "round" => roundId = 0,
            "battle" => battleId = 0,
            _ => 
        };
        */
            switch (objectId)
            {
                case "character":
                    characterId = 0;
                    break;
                case "round":
                    roundId = 0;
                    break;
                case "battle":
                    battleId = 0;
                    break;
            }
        }
    }
}
