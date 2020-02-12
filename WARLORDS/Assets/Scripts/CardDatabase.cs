using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        //cardID, cardName, actionPoints, cardAttack, cardHealth, cardDescription, cardSprite, cardColor, cardFaction
        //Chinese Cards
        //ID 0 - 15
        cardList.Add(new Card(0, "Halberdier", 3, 200, 300, "(+)100 attack against Cavalry. Takes 50% damage from melee cavalry", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(1, "Cataphracts", 5, 300, 600, "", Resources.Load<Sprite>("2"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(2, "Chu-Ko-Nu", 3, 150, 250, "Can attack twice", Resources.Load<Sprite>("3"), "Blue", Card.CardFaction.CHINESE));
        cardList.Add(new Card(3, "Mounted Archers", 5, 150, 400, "Can move after attacking is possible", Resources.Load<Sprite>("4"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(4, "Mangonel", 1, 500, 300, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("5"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(5, "Triple-bow Ballista", 1, 400, 300, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("6"), "Blue", Card.CardFaction.CHINESE));
        cardList.Add(new Card(6, "Hungry Falcon Cart", 1, 700, 1000, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("7"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(7, "Cloud Ladder", 1, 0, 1500, "Allows non siege or cavalry troops to scale enemy fortifications. This unit becomes invulnerable to siege units once it reaches the fortification", Resources.Load<Sprite>("8"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(8, "Make sound in the east, strike in the west", 0, 0, 0, "Discard all active fortifications and the current Terrain and play a fortification and or terrain card from your hand or deck", Resources.Load<Sprite>("9"), "Blue", Card.CardFaction.CHINESE));
        cardList.Add(new Card(9, "False Information", 0, 0, 0, "When your enemy uses a strategy that reveals one of your cards, reveal this card instead", Resources.Load<Sprite>("10"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(10, "Fake Injury", 0, 0, 0, "I'm an Elf", Resources.Load<Sprite>("11"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(11, "Land Mine", 0, 0, 0, "I'm a Dwarf", Resources.Load<Sprite>("12"), "Blue", Card.CardFaction.CHINESE));
        cardList.Add(new Card(12, "Confusion", 0, 0, 0, "None", Resources.Load<Sprite>("13"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(13, "Signal Arrow", 0, 0, 0, "I'm an Elf", Resources.Load<Sprite>("14"), "Red", Card.CardFaction.CHINESE));
        cardList.Add(new Card(14, "Force Reconnaissance", 0, 0, 0, "I'm a Dwarf", Resources.Load<Sprite>("15"), "Blue", Card.CardFaction.CHINESE));
        cardList.Add(new Card(15, "Great Wall", 0, 0, 0, "None", Resources.Load<Sprite>("16"), "Red", Card.CardFaction.CHINESE));

        //Roman Cards
        cardList.Add(new Card(16, "Human", 2, 1000, 100, "I'm a human", Resources.Load<Sprite>("1"), "Blue", Card.CardFaction.ROMANS));
        cardList.Add(new Card(17, "Demon", 2, 4000, 500, "I'm an demon", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS));


    }
}
