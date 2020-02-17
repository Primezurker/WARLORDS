using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveyardPile : MonoBehaviour
{
    public List<GameObject> graveyard = new List<GameObject>();
    public GameObject hand;

    private void Start()
    {
        hand = GameObject.FindGameObjectWithTag("Hand");
    }

    public void ReturnToHand()
    {
        graveyard[0].GetComponent<Draggable>().dropped = false;
        graveyard[0].GetComponent<CanvasGroup>().blocksRaycasts = true;
        graveyard[0].transform.SetParent(hand.transform);
        graveyard.RemoveAt(0);
    }
}
