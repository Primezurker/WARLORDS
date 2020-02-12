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

    public GameObject cardToHand;
    public GameObject cardBackObj;
    public GameObject deckObj;

    public GameObject [] cardClones;
    public GameObject hand;

    void Awake()
    {
        x = 0;
        deckSize = 60;
    }

    void Start()
    {
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, CardDatabase.cardList.Count);
            deck[i] = CardDatabase.cardList[x];
        }
    }

    void Update()
    {
        //Hardcoding value now. Need to have percentage values
        if (deckSize < 45) //75% of Decksize
        {
            cardInDeck1.SetActive(false);
        }
        else if (deckSize < 30) //50% of Decksize
        {
            cardInDeck2.SetActive(false);
        }
        else if (deckSize < 15) //25% of Decksize
        {
            cardInDeck3.SetActive(false);
        }
        else if (deckSize <= 0) //No cards left
        {
            cardInDeck4.SetActive(false);
        }
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
}
