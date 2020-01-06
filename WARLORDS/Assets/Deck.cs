using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Deck : MonoBehaviour
{
    Text deckSizeText;
    public int deckSize = 10;
    public string deckType;
    public Cards[] deck;
    public Hand hand;

    void Awake()
    {
        deckSizeText = GetComponentInChildren<Text>();
    }
    void Start()
    {
        CheckDeckSize();
    }

    public void DrawCards()
    {
        if(deckSize >= 1 && hand.handSize < hand.maxSize)
        {
            deckSize--;
            int cardToDraw = Random.Range(0, deck.Length);
            hand.HandCheck(deck[cardToDraw]);
        }
        else
        {
            Debug.Log("Out of Cards" + " or Hand is Full");
        }
        CheckDeckSize();
    }

    void CheckDeckSize()
    {
        deckSizeText.text = deckSize.ToString();
    }
}