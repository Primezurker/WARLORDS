using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public int handSize;
    public int maxHandSize = 10;

    public void Update()
    {
        handSize = transform.childCount;
        Debug.LogError(handSize);
    }
}
