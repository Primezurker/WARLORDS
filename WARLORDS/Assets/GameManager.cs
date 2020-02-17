using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerDeck playerDeck;

    private void Awake()
    {
        playerDeck = FindObjectOfType<PlayerDeck>();
    }

    void Start()
    {
        Application.targetFrameRate = 300;
        StartCoroutine(GameStartDrawingCard());
    }

    IEnumerator GameStartDrawingCard()
    {
        for(int i = 0; i <= 5; i++)
        {
            yield return new WaitForSeconds(1);
            playerDeck.StartingShuffle();
            playerDeck.StartingShuffle();
            playerDeck.StartingShuffle();
            playerDeck.DrawCard();
        }
    }
}
