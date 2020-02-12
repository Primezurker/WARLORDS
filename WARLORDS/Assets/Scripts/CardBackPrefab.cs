using UnityEngine;

public class CardBackPrefab : MonoBehaviour
{
    public GameObject deck;
    public GameObject it;

    private void Update()
    {
        deck = GameObject.Find("Deck");
        it.transform.SetParent(deck.transform);
        it.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        it.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
