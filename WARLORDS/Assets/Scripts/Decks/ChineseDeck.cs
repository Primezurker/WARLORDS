using System.Collections.Generic;

public class ChineseDeck : CardDatabase
{
    public List<Card> chineseDeck = new List<Card>();

    void Start()
    {
        //3 Halberdier
        chineseDeck[0] = cardList[0];
        chineseDeck[1] = cardList[0];
        chineseDeck[2] = cardList[0];
        //2 Cataphracts
        chineseDeck[3] = cardList[1];
        chineseDeck[4] = cardList[1];
        //4 Chu-Ko-Nu
        chineseDeck[5] = cardList[2];
        chineseDeck[6] = cardList[2];
        chineseDeck[7] = cardList[2];
        chineseDeck[8] = cardList[2];
        //2 Mounted Archers
        chineseDeck[9] = cardList[3];
        chineseDeck[10] = cardList[3];
        //1 Mangonel
        chineseDeck[11] = cardList[4];
        // 1 Triple-bow Ballista
        chineseDeck[12] = cardList[5];
        //1 Hungry Falcon Cart
        chineseDeck[13] = cardList[6];
        //1 Cloud Ladder
        chineseDeck[14] = cardList[7];
        //1 Make Sound in the East, Strike in the West
        chineseDeck[15] = cardList[8];
        //1 False Information
        chineseDeck[16] = cardList[9];
        //2 Fake Injury
        chineseDeck[17] = cardList[10];
        chineseDeck[18] = cardList[10];
        //1 Land Mine
        chineseDeck[19] = cardList[11];
        //1 Confusion
        chineseDeck[20] = cardList[12];
        //1 Signal Arrow
        chineseDeck[21] = cardList[13];
        //2 Force Reconnaissance
        chineseDeck[22] = cardList[14];
        chineseDeck[23] = cardList[14];
        // 1 Great Wall
        chineseDeck[24] = cardList[15];
        //5 Infantry
        chineseDeck[25] = cardList[55];
        chineseDeck[26] = cardList[55];
        chineseDeck[27] = cardList[55];
        chineseDeck[28] = cardList[55];
        chineseDeck[29] = cardList[55];
        //3 Light Cavalry
        chineseDeck[30] = cardList[56];
        chineseDeck[31] = cardList[56];
        chineseDeck[32] = cardList[56];
        //3 Archers
        chineseDeck[33] = cardList[57];
        chineseDeck[34] = cardList[57];
        chineseDeck[35] = cardList[57];
        //1 Battering Ram
        chineseDeck[36] = cardList[60];
        //1 Tunneling
        chineseDeck[37] = cardList[61];
        //2 Ambush
        chineseDeck[38] = cardList[62];
        chineseDeck[39] = cardList[62];
        //2 Route
        chineseDeck[40] = cardList[63];
        chineseDeck[41] = cardList[63];
        //2 Forced March
        chineseDeck[42] = cardList[64];
        chineseDeck[43] = cardList[64];
        //2 Charge
        chineseDeck[44] = cardList[65];
        chineseDeck[45] = cardList[65];
        //1 Retreat
        chineseDeck[46] = cardList[66];
        //2 Shield Wall
        chineseDeck[47] = cardList[67];
        chineseDeck[48] = cardList[67];
        //2 Supplementary Training
        chineseDeck[49] = cardList[68];
        chineseDeck[50] = cardList[68];
        //2 Supply Chain
        chineseDeck[51] = cardList[69];
        chineseDeck[52] = cardList[69];
        //2 Forage
        chineseDeck[53] = cardList[70];
        chineseDeck[54] = cardList[70];
        //1 Scout
        chineseDeck[55] = cardList[71];
        //1 Spy
        chineseDeck[56] = cardList[72];
        //1 Saboteur
        chineseDeck[57] = cardList[73];
        //2 Reinforcements
        chineseDeck[58] = cardList[74];
        chineseDeck[59] = cardList[74];
    }
}