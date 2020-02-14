using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public enum DeckType { ROMANS, CHINESE }
    public DeckType deckType;
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();

    public int x;
    public int deckSize;

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;

    public GameObject cardBackObj;
    public GameObject cardToDraw;
    public GameObject drawToHand;
    public GameObject [] cardClones;

    public Hand hand;

    void Awake()
    {
        x = 0;
        deckSize = 60;
    }

    void Start()
    {
        for (int i = 0; i < deckSize; i++)
        {
            if(deckType == DeckType.CHINESE)
            {
                x = Random.Range(0, 16);
                deck[i] = CardDatabase.cardList[x];
                Debug.LogError(deck[i].typeOfFaction);
            }
            else if(deckType == DeckType.ROMANS)
            {
                x = Random.Range(16, 35);
                deck[i] = CardDatabase.cardList[x];
                Debug.LogError(deck[i].typeOfFaction);
            }
        }
        drawToHand = GameObject.FindGameObjectWithTag("Hand");
        hand = drawToHand.GetComponent<Hand>();
    }

    void Update()
    {
        //Hardcoding value now. Need to have percentage values
        if (deckSize < 45) //75% of Decksize
        {
            cardInDeck1.SetActive(false);
        }
        if (deckSize < 30) //50% of Decksize
        {
            cardInDeck2.SetActive(false);
        }
        if (deckSize < 15) //25% of Decksize
        {
            cardInDeck3.SetActive(false);
        }
        if (deckSize <= 0) //No cards left
        {
            cardInDeck4.SetActive(false);
        }
        deckSize = deck.Count;
    }

    IEnumerator DeckShuffle()
    {
        yield return new WaitForSeconds(1);
        cardClones = GameObject.FindGameObjectsWithTag("Clone");

        foreach(GameObject clone in cardClones)
        {
            Destroy(clone);
        }
    }

    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
        GameObject clone = Instantiate(cardBackObj, transform.position, transform.rotation);
        clone.tag = "Clone";
        StartCoroutine(DeckShuffle());
    }

    public void DrawCard()
    {
        if(hand.handSize < hand.maxHandSize)
        {
            GameObject drawnCard = Instantiate(cardToDraw, hand.transform.position, hand.transform.rotation);
            ThisCard _drawnCard = drawnCard.GetComponent<ThisCard>();

            _drawnCard.cardID = deck[deck.Count - 1].id;
            _drawnCard.UpdateCard();
            drawnCard.transform.SetParent(hand.transform);
            deck.RemoveAt(deck.Count - 1);

            if (deck.Count == 0)
            {
                Debug.LogError("Out of Cards");
            }
        }
        else
        {
            Debug.LogError("Hand is Full");
        }
    }
}
