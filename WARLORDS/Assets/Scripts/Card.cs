using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public int id;
    public string cardName;
    public int actionPoints;
    public int cardAttack;
    public int cardHealth;
    public string cardDescription;
    public Sprite cardImage;
    public string cardColor;
    public enum CardFaction { CHINESE, ROMANS, GREEK, INDIANS, NORSE, UNIVERSAL}
    public enum CardType { MELEE, RANGED, SIEGE, GRAND_STRATEGY, TACTIC, TRAP, AUXILIARY, TERRAIN, FORTIFICATION}
    public enum CardRole { UNIT, STRATEGY, FIELD}
    public CardFaction typeOfFaction;
    public CardType cardType;
    public CardRole cardRole;

    public Card(int _id, string _cardName, int _actionPoints, int _cardAttack, int _cardHealth, string _cardDescription, Sprite _cardImage, string _cardColor, CardFaction _cardFaction, CardType _cardType, CardRole _cardRole)
    {
        id = _id;
        cardName = _cardName;
        actionPoints = _actionPoints;
        cardAttack = _cardAttack;
        cardHealth = _cardHealth;
        cardDescription = _cardDescription;
        cardImage = _cardImage;
        cardColor = _cardColor;
        typeOfFaction = _cardFaction;
        cardType = _cardType;
        cardRole = _cardRole;
    }
}
