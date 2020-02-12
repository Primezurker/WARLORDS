using UnityEngine;

public class CardToHand : MonoBehaviour
{
    public GameObject hand;
    public GameObject it;

    private void Update()
    {
        hand = GameObject.Find("Hand");
        it.transform.SetParent(hand.transform);
        it.transform.localScale = Vector3.one;
        it.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        it.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
