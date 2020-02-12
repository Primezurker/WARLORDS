using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();
    public int cardID;

    public int id;
    public string cardName;
    public int actionPoints;
    public int cardAttack;
    public int cardHealth;
    public string cardDescription;
    public string cardFaction;

    public Text cardNameText;
    public Text actionPointsText;
    public Text cardAttackText;
    public Text cardHealthText;
    public Text cardDescriptionText;
    public Text cardFactionText;

    public Sprite cardSprite;
    public Image cardImage;
    public Image cardFrame;

    public GameObject cardBack;

    public bool isCardBack = false;

    void Start()
    {
        thisCard[0] = CardDatabase.cardList[cardID];
    }

    void Update()
    {
        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        actionPoints = thisCard[0].actionPoints;
        cardAttack = thisCard[0].cardAttack;
        cardHealth = thisCard[0].cardHealth;
        cardDescription = thisCard[0].cardDescription;
        cardFaction = thisCard[0].typeOfFaction.ToString();

        cardSprite = thisCard[0].cardImage;
        
        //ToDisplay Card Info
        cardNameText.text = "" + cardName;
        actionPointsText.text = "" + actionPoints;
        cardAttackText.text = "" + cardAttack;
        cardHealthText.text = "" + cardHealth;
        cardDescriptionText.text = "" + cardDescription;
        cardFactionText.text = "" + cardFaction;

        cardImage.sprite = cardSprite;
        if(thisCard[0].cardColor == "Red")
        {
            cardFrame.color = Color.red;
        }
        else if (thisCard[0].cardColor == "Blue")
        {
            cardFrame.color = Color.blue;
        }
        else if (thisCard[0].cardColor == "Green")
        {
            cardFrame.color = Color.green;
        }

        if(isCardBack == true)
        {
            cardBack.SetActive(true);
        }
        else
        {
            cardBack.SetActive(false);
        }
    }
}
