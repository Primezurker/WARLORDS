using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Cards cards;
    public Image cardRarity;
    public Image cardImage;
    public Text cardName;
    public Text cardDescritpion;
    public Text cardAttack;
    public Text cardDefense;

    public void DisplayCard(Cards cardToDisplay)
    {
        cards = cardToDisplay;
        cardRarity.sprite = cards.rarity;
        cardImage.sprite = cards.cardSprite;
        cardName.text = cards.cardName;
        cardDescritpion.text = cards.cardText;
        cardAttack.text = cards.cardAttack.ToString();
        cardDefense.text = cards.cardDefense.ToString();
    }
}
