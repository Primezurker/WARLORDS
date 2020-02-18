using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerDeck playerDeck;
    public TurnSystem turnSystem;
    public bool playerWon;

    void Awake()
    {
        playerDeck = FindObjectOfType<PlayerDeck>();
        turnSystem = FindObjectOfType<TurnSystem>();
    }

    void Start()
    {
        Application.targetFrameRate = 300;
        playerDeck.PopulateDeck();
    }

    public void GameStartPhase()
    {
        StartCoroutine(GameStartDrawingCard());
    }

    IEnumerator GameStartDrawingCard()
    {
        for (int i = 0; i <= 5; i++)
        {
            yield return new WaitForSeconds(1);
            playerDeck.StartingShuffle();
            playerDeck.DrawCard();
            if (i >= 5)
            {
                turnSystem.beginCountDown = true;
                turnSystem.NextPhase();
                turnSystem.gameStarted = true;
            }
        }
    }
}
