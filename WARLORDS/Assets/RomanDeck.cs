using System.Collections.Generic;

public class RomanDeck : CardDatabase
{
    public List<Card> romanDeck = new List<Card>();

    void Start()
    {
        //7 Legion Cohort
        romanDeck[0] = cardList[16];
        romanDeck[1] = cardList[16];
        romanDeck[2] = cardList[16];
        romanDeck[3] = cardList[16];
        romanDeck[4] = cardList[16];
        romanDeck[5] = cardList[16];
        romanDeck[6] = cardList[16];
        //2 Cataphracts
        romanDeck[7] = cardList[17];
        romanDeck[8] = cardList[17];
        //3 Scorpion Balista
        romanDeck[9] = cardList[18];
        romanDeck[10] = cardList[18];
        romanDeck[11] = cardList[18];
        //1 Siege Tower
        romanDeck[12] = cardList[19];
        //1 Testudo Arietaria
        romanDeck[13] = cardList[20];
        // 1 Carrobalista
        romanDeck[14] = cardList[21];
        //1 Onager
        romanDeck[15] = cardList[22];
        //1 Walled Encirclement
        romanDeck[16] = cardList[23];
        //1 Sapper
        romanDeck[17] = cardList[24];
        //2 Testudo
        romanDeck[18] = cardList[25];
        romanDeck[19] = cardList[25];
        //2 Pilum Volley
        romanDeck[20] = cardList[26];
        romanDeck[21] = cardList[26];
        //2 Caltrops
        romanDeck[22] = cardList[27];
        romanDeck[23] = cardList[27];
        //2 Reserve Troops
        romanDeck[24] = cardList[28];
        romanDeck[25] = cardList[28];
        //2 Legion Eagle Bearer
        romanDeck[26] = cardList[29];
        romanDeck[27] = cardList[29];
        //1 Adaptation
        romanDeck[28] = cardList[30];
        // 1 Hire Mercenaries
        romanDeck[29] = cardList[31];
        //2 Surgeon
        romanDeck[30] = cardList[32];
        romanDeck[31] = cardList[32];
        //1 Hadrians Wall
        romanDeck[32] = cardList[33];
        //1 Palisade
        romanDeck[33] = cardList[34];
        //3 Light Cavalry
        romanDeck[34] = cardList[56];
        romanDeck[35] = cardList[56];
        romanDeck[36] = cardList[56];
        //3 Archers
        romanDeck[37] = cardList[57];
        romanDeck[38] = cardList[57];
        romanDeck[39] = cardList[57];
        //2 Ambush
        romanDeck[40] = cardList[62];
        romanDeck[41] = cardList[62];
        //1 Route
        romanDeck[42] = cardList[63];
        //2 Forced March
        romanDeck[43] = cardList[64];
        romanDeck[44] = cardList[64];
        //2 Charge
        romanDeck[45] = cardList[65];
        romanDeck[46] = cardList[65];
        //1 Retreat
        romanDeck[47] = cardList[66];
        //2 Supplementary Training
        romanDeck[48] = cardList[68];
        romanDeck[49] = cardList[68];
        //2 Supply Chain
        romanDeck[50] = cardList[69];
        romanDeck[51] = cardList[69];
        //2 Forage
        romanDeck[52] = cardList[70];
        romanDeck[53] = cardList[70];
        //2 Scout
        romanDeck[54] = cardList[71];
        romanDeck[55] = cardList[71];
        //1 Spy
        romanDeck[56] = cardList[72];
        //1 Saboteur
        romanDeck[57] = cardList[73];
        //2 Reinforcements
        romanDeck[58] = cardList[74];
        romanDeck[59] = cardList[74];
    }
}
