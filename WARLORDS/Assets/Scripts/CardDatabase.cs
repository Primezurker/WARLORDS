using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        //cardID, cardName, actionPoints, cardAttack, cardHealth, cardDescription, cardSprite, cardColor, cardFaction, cardType
        //Chinese Cards
        //ID 0 - 15
        cardList.Add(new Card(0, "Halberdier", 3, 200, 300, "(+)100 attack against Cavalry. Takes 50% damage from melee cavalry", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.CHINESE, Card.CardType.MELEE));
        cardList.Add(new Card(1, "Cataphracts", 5, 300, 600, "", Resources.Load<Sprite>("2"), "Red", Card.CardFaction.CHINESE, Card.CardType.MELEE));
        cardList.Add(new Card(2, "Chu-Ko-Nu", 3, 150, 250, "Can attack twice", Resources.Load<Sprite>("3"), "Blue", Card.CardFaction.CHINESE, Card.CardType.RANGED));
        cardList.Add(new Card(3, "Mounted Archers", 5, 150, 400, "Can move after attacking is possible", Resources.Load<Sprite>("4"), "Red", Card.CardFaction.CHINESE, Card.CardType.RANGED));
        cardList.Add(new Card(4, "Mangonel", 1, 500, 300, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("5"), "Red", Card.CardFaction.CHINESE, Card.CardType.SIEGE));
        cardList.Add(new Card(5, "Triple-bow Ballista", 1, 400, 300, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("6"), "Blue", Card.CardFaction.CHINESE, Card.CardType.SIEGE));
        cardList.Add(new Card(6, "Hungry Falcon Cart", 1, 700, 1000, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("7"), "Red", Card.CardFaction.CHINESE, Card.CardType.SIEGE));
        cardList.Add(new Card(7, "Cloud Ladder", 1, 0, 1500, "Allows non siege or cavalry troops to scale enemy fortifications. This unit becomes invulnerable to siege units once it reaches the fortification", Resources.Load<Sprite>("8"), "Red", Card.CardFaction.CHINESE, Card.CardType.SIEGE));
        cardList.Add(new Card(8, "Make sound in the east, strike in the west", 0, 0, 0, "Discard all active fortifications and the current Terrain and play a fortification and or terrain card from your hand or deck", Resources.Load<Sprite>("9"), "Blue", Card.CardFaction.CHINESE, Card.CardType.GRAND_STRATEGY));
        cardList.Add(new Card(9, "False Information", 0, 0, 0, "When your enemy uses a strategy that reveals one of your cards, reveal this card instead", Resources.Load<Sprite>("10"), "Red", Card.CardFaction.CHINESE, Card.CardType.TRAP));
        cardList.Add(new Card(10, "Fake Injury", 0, 0, 0, "I'm an Elf", Resources.Load<Sprite>("11"), "Red", Card.CardFaction.CHINESE, Card.CardType.TRAP));
        cardList.Add(new Card(11, "Land Mine", 0, 0, 0, "I'm a Dwarf", Resources.Load<Sprite>("12"), "Blue", Card.CardFaction.CHINESE, Card.CardType.TRAP));
        cardList.Add(new Card(12, "Confusion", 0, 0, 0, "Targeted enemy unit takes 50% more damage this turn", Resources.Load<Sprite>("13"), "Red", Card.CardFaction.CHINESE, Card.CardType.AUXILIARY));
        cardList.Add(new Card(13, "Signal Arrow", 0, 0, 0, "Target an enemy unit and all of your Chinese units within range attack that unit at the same time", Resources.Load<Sprite>("14"), "Red", Card.CardFaction.CHINESE, Card.CardType.AUXILIARY));
        cardList.Add(new Card(14, "Force Reconnaissance", 0, 0, 0, "Target one of your enemy's face down cards and reveal it. If it is a trap or auxiliary card destroy it", Resources.Load<Sprite>("15"), "Blue", Card.CardFaction.CHINESE, Card.CardType.AUXILIARY));
        cardList.Add(new Card(15, "Great Wall", 3, 0, 10000, "", Resources.Load<Sprite>("16"), "Red", Card.CardFaction.CHINESE, Card.CardType.FORTIFICATION));

        //Roman Cards 16-34
        cardList.Add(new Card(16, "Legion Cohort", 3, 200, 500, "Recieves 50% damage from missle units", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.MELEE));
        cardList.Add(new Card(17, "Cataphracts", 5, 300, 600, "", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.MELEE));
        cardList.Add(new Card(18, "Scorpion Ballista", 3, 200, 500, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.RANGED));
        cardList.Add(new Card(19, "Siege Tower", 2, 4000, 500, "Allows none siege or cavalry troops to scale enemy fortifications. This unit becomes invulnerable to siege units once it reaches the fortification. Can only attack fortifications", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.SIEGE));
        cardList.Add(new Card(20, "Testudo Arietaria", 3, 200, 500, "This unit becomes invulnerable to siege unitts once it reaches the fortification. Can only attack fortiffications", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.SIEGE));
        cardList.Add(new Card(21, "Carroballista", 2, 4000, 500, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.SIEGE));
        cardList.Add(new Card(22, "Onager", 3, 200, 500, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.SIEGE));
        cardList.Add(new Card(23, "Walled Encirclement", 2, 4000, 500, "Why waste troops attacking a fortification when you can just starve them out? Build a wall fortification around your enemy that has 10,000 health, while encircled your enemy cannot field more units and will lose 500 resource per turn until either their resources reach zero or until the wall is destroyed", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.GRAND_STRATEGY));
        cardList.Add(new Card(24, "Sappers", 3, 200, 500,"Collapse your enemy''s fortification by tunneling beneath it and igniting incendiaries", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.GRAND_STRATEGY));
        cardList.Add(new Card(25, "Tetsudo", 2, 4000, 500, "Taking inspiration from the tortus, your Legionaries group together in a shield formation that completely protects them from missle and melee infantry attacks. Choose a Legion Cohort unit and they become immune to damage until your next turn.", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.TACTIC));
        cardList.Add(new Card(26, "Pilum Volley", 3, 200, 500, "Your Legionaries launch their Pilums at a targeted enemy within 1 row from them. Deal 100 missle damage to an enemy within 2 spaces. If applicable discard their shield", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.TACTIC));
        cardList.Add(new Card(27, "Caltrops", 2, 4000, 500, "Small spikes designed to pierce the feet of any who are unlucky enough not to notice them. Thhis card may be activated when an enemy unit moves, the unit takes 50 damage and disables the unit for the turn", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.TRAP));
        cardList.Add(new Card(28, "Reserve Troops", 3, 200, 500, "Troops help in reserve to reinforce battle lines where they are weak. When an enemy declares an attack, select a unit wthin one space of the targeted unit and combine forces.", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.TRAP));
        cardList.Add(new Card(29, "Legion Eagle Bearer", 2, 4000, 500, "Equip this to a Roman unit, when that unit is killed, this card is discarded as well. Only one Legion Eagle Bearer can be in play at a time", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.AUXILIARY));
        cardList.Add(new Card(30, "Adaptation", 3, 200, 500, "Adapt and overcome. Select a unit from your enemy's discard pile and field it at double the cost", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.AUXILIARY));
        cardList.Add(new Card(31, "Hire Mercenaries", 2, 4000, 500, "Unfortunately Legionaries can't do everything. But thats what the lesser nations are for. Pick one mercenary unit from 3 options and field them next to your General", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.AUXILIARY));
        cardList.Add(new Card(32, "Surgeon", 2, 4000, 500, "Select a unit on the field and restore it to max health", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.AUXILIARY));
        cardList.Add(new Card(33, "Hadrian's Wall", 3, 0, 7500, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.ROMANS, Card.CardType.FORTIFICATION));
        cardList.Add(new Card(34, "Palisade", 1, 0, 2500, "", Resources.Load<Sprite>("1"), "Green", Card.CardFaction.ROMANS, Card.CardType.FORTIFICATION));

        //Greek Cards 35-44
        cardList.Add(new Card(35, "Hoplite Phalanx", 2, 200, 500, "Take 50% damage from missle attacks and melee that attack from the front. Take 150% damage from attacks from sides or rear", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.MELEE));
        cardList.Add(new Card(36, "Hetairoi", 5, 300, 400, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.MELEE));
        cardList.Add(new Card(37, "Cataphracts", 5, 300, 600, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.MELEE));
        cardList.Add(new Card(38, "Gasthraphets", 3, 200, 250, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.RANGED));
        cardList.Add(new Card(39, "Siege Tower", 1, 0, 2000, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.SIEGE));
        cardList.Add(new Card(40, "Carroballista", 1, 400, 300, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.SIEGE));
        cardList.Add(new Card(41, "Trojan Horse", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.GRAND_STRATEGY));
        cardList.Add(new Card(42, "Oblique Order", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.TACTIC));
        cardList.Add(new Card(43, "Sarissa", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.AUXILIARY));
        cardList.Add(new Card(44, "Hot Gates", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.GREEK, Card.CardType.TERRAIN));

        //Indian Cards 45-48
        cardList.Add(new Card(45, "Kshatriya", 3, 250, 500, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.MELEE));
        cardList.Add(new Card(46, "War Elephants", 3, 250, 1000, "Cannot retaliate when attacked. Archer units can ride War Elephant and attack enemies. When riding the War Elephant. Archers cannot move and cannot be attacked by melee units. However if the War Elephant is killed, so are the archers", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.MELEE));
        cardList.Add(new Card(47, "Cataphracts", 5, 300, 600, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.MELEE));
        cardList.Add(new Card(48, "Mounted Archers", 5, 150, 300, "Can move after attacking if possible", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.RANGED));

        //Norse Cards 49-54
        cardList.Add(new Card(49, "Berserker", 3, 200, 300, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.MELEE));
        cardList.Add(new Card(50, "Fire Birds", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.GRAND_STRATEGY));
        cardList.Add(new Card(51, "Berserker's Rage", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.AUXILIARY));
        cardList.Add(new Card(52, "Viking", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.AUXILIARY));
        cardList.Add(new Card(53, "Battle Cry", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.INDIANS, Card.CardType.AUXILIARY));
        cardList.Add(new Card(54, "Stamford Bridge", 0, 0, 0, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.NORSE, Card.CardType.TERRAIN));

        //Universal Cards  55-74
        cardList.Add(new Card(55, "Infantry", 3, 200, 300, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.MELEE));
        cardList.Add(new Card(56, "Light Cavalry", 5, 300, 400, "Can move after attacking if possible", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.MELEE));
        cardList.Add(new Card(57, "Archers", 3, 150, 250, "", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.RANGED));
        cardList.Add(new Card(58, "Siege Ladders", 3, 0, 300, "This unit becomes invulnerable once it reaches the enemy fortification. Allows non siege or cavalry troops to scale enemy fortifications", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.SIEGE));
        cardList.Add(new Card(59, "Catapults", 1, 350, 300, "Can only attack fortifications and Siege units", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.SIEGE));
        cardList.Add(new Card(60, "Battering Ram", 1, 500, 500, "This unit becomes invulnerable to siege units once it reaches the fortification. Can only attack fortifications", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.SIEGE));
        cardList.Add(new Card(61, "Tunneling", 0, 0, 0, "If you can't go over it, go under it. Destroy 1 section of an enemies fortification", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.GRAND_STRATEGY));
        cardList.Add(new Card(62, "Ambush", 0, 0, 0, "If an enemy unit within 2 spaces of one of your units moves, attack it with that unit", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.TRAP));
        cardList.Add(new Card(63, "Route", 0, 0, 0, "If an enemy unit within 2 spaces of your unit declares a move that takes them out of range of one of your units, attack that enemy unit", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.TRAP));
        cardList.Add(new Card(64, "Forced March", 0, 0, 0, "Select a friendly unit and move it forward one space", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.TACTIC));
        cardList.Add(new Card(65, "Charge", 0, 0, 0, "Select a friendly melee unit and move them by 1 and attack an enemy unit for +50 attack. If the selected unit's action parts are exhausted they do 50% normal damage instead", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.TACTIC));
        cardList.Add(new Card(66, "Retreat", 0, 0, 0, "Select a friendly unit and move them back 1 space", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.TACTIC));
        cardList.Add(new Card(67, "Shield Wall", 0, 0, 0, "Designate a shielded unit and it becomes immune to damage until next turn. However it cannot attack or move while shield wall is in effect", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.TACTIC));
        cardList.Add(new Card(68, "Supplementary Training", 3, 200, 300, "Select a unit and increase their number of action points by 1", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.AUXILIARY));
        cardList.Add(new Card(69, "Supply Chain", 3, 200, 300, "An army marches on its stomach. Draw an extra card per turn", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.AUXILIARY));
        cardList.Add(new Card(70, "Forage", 3, 200, 300, "Draw 3 cards", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.AUXILIARY));
        cardList.Add(new Card(71, "Scout", 0, 0, 0, "Scout out the enemy. Select one face down strategy card and reveal it. If it is a trap, destroy it.", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.AUXILIARY));
        cardList.Add(new Card(72, "Spy", 0, 0, 0, "Sneak a spy into your enemy's camp. Select 3 cards in your enemy's hand and reveal them", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.AUXILIARY));
        cardList.Add(new Card(73, "Saboteur", 0, 0, 0, "Select the top 5 cards of your enemy's deck, look at them, discard one and rearrange the rest into any order you want and return them to the top of their deck", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.AUXILIARY));
        cardList.Add(new Card(74, "Reinforcements", 0, 0, 0, "Draw from your deck until you draw a Unit, play it to the field and return the rest to the deck and shuffle", Resources.Load<Sprite>("1"), "Red", Card.CardFaction.UNIVERSAL, Card.CardType.AUXILIARY));
    }
}
