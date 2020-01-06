using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    Cards card;
    public Cards[] hand;
    public string deckType;
    public Transform[] handLocation;
    public int handSize = 0;
    public int maxSize = 3;


    public void HandCheck(Cards cardToDraw)
    {
        if(hand[0] == null)
        {
            hand[0] = (Cards)Resources.Load(deckType + "/" + cardToDraw.name, typeof(Cards));
            handLocation[0].GetComponentInChildren<CardDisplay>().DisplayCard(cardToDraw);
            handSize++;
        }
        else if (hand[1] == null)
        {
            hand[1] = (Cards)Resources.Load(deckType + "/" + cardToDraw.name, typeof(Cards));
            handLocation[1].GetComponentInChildren<CardDisplay>().DisplayCard(cardToDraw);
            handSize++;
        }
        else if (hand[2] == null)
        {
            hand[2] = (Cards)Resources.Load(deckType + "/" + cardToDraw.name, typeof(Cards));
            handLocation[2].GetComponentInChildren<CardDisplay>().DisplayCard(cardToDraw);
            handSize++;
        }
        else
        {
            Debug.Log("Hand is Full");
            return;
        }
    }
}
