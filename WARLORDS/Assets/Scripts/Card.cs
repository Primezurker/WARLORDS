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
    public enum CardFaction { CHINESE, ROMANS }
    //public enum CardType { MELEE, RANGED }
    public CardFaction typeOfFaction;
    //public CardType cardType;


    public Card(int _id, string _cardName, int _actionPoints, int _cardAttack, int _cardHealth, string _cardDescription, Sprite _cardImage, string _cardColor, CardFaction _cardFaction/*, CardType _cardType*/)
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
        //cardType = _cardType;
    }
}
