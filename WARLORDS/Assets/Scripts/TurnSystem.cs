using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public PlayerDeck playerDeck;
    public GameManager gameManager;

    public bool isYourTurn;
    public int turnCount = 0;
    public Text turnCountText;
    public Text whoseTurnText;
    public Text turnTimerText;

    public Text dp_Text;
    public Text ap_One_Text;
    public Text bp_Text;
    public Text ap_Two_Text;
    public Text ep_Text;

    public int phase = 0; //0 is Game Start Phase; 1 is Draw Phase 2 is Action Phase One; 3 is Battle Phase; 4 is Action Phase Two; 5 is End Phase;

    public bool gameStarted;
    bool cardDrawn;

    public bool beginCountDown = false;
    public float startTime = 30;
    public float currTime = 0;

    void Awake()
    {
        phase = 0;
        isYourTurn = true;
        turnCount = 0;
        ResetTimer();
    }

    void Start()
    {
        Phases();
    }

    void Update()
    {
        if(isYourTurn == true)
        {
            whoseTurnText.text = "Your Turn";
        }
        else
        {
            whoseTurnText.text = "Opponent Turn";
        }
        turnTimerText.text = currTime.ToString("F2");
        turnCountText.text = turnCount.ToString();
        if (beginCountDown)
        {
            currTime -= 1 * Time.deltaTime;
            if(currTime <= 0)
            {
                currTime = Mathf.Clamp(currTime, 0, startTime);
                beginCountDown = false;
                EndTurn();
            }
        }
    }

    public void ResetTimer()
    {
        currTime = startTime;
    }

    public void EndYourTurn()
    {
        isYourTurn = false;
        turnCount++;
        Debug.LogError("Ending Your Turn");
    }

    public void EndYourOpponentTurn()
    {
        isYourTurn = true;
        turnCount++;
        Debug.LogError("Ending Opponents Turn");
    }

    public void EndTurn()
    {
        if(isYourTurn == true)
        {
            EndYourTurn();
            ResetTimer();
            phase = 1;
            Phases();
        }
        else
        {
            EndYourOpponentTurn();
            ResetTimer();
            phase = 1;
        }
        beginCountDown = true;
        cardDrawn = false;
    }

    public void Phases()
    {
        switch (phase)
        {
            default:
                Debug.Log("Game Started Phase");
                GameStartPhase();
                break;

            case 1:
                Debug.LogError("Draw Phase");
                DrawPhase();
                break;

            case 2:
                Debug.LogError("Action Phase One");
                ActionPhaseOne();

                break;

            case 3:
                Debug.LogError("Battle Phase");
                BattlePhase();

                break;

            case 4:
                Debug.LogError("Action Phase Two");
                ActionPhaseTwo();

                break;

            case 5: 
                Debug.LogError("End Phase");
                EndPhase();

                break;
            case 6:
                SwitchSides();
                break;
        }
    }

    #region Phases

    public void GameStartPhase()
    {
        //Draw 6 Cards
        if(gameStarted == false)
        {
            gameManager.GameStartPhase();
        }
        else
        {
            phase = 1;
            Phases();
        }
        //Can replace 2 cards -OR- replace entire hand
    }

    public void DrawPhase()
    {
        //Draw One Card
        if(cardDrawn == false)
        {
            playerDeck.DrawCard();
            ResetTimer();
            beginCountDown = true;
            cardDrawn = true;
        }
        DisplayTurn();
        dp_Text.color = Color.green;
    }

    public void ActionPhaseOne()
    {
        //Play or move Unit cards
        //Play Strategy Card
        //Play Field Card
        cardDrawn = false;
        DisplayTurn();
        ap_One_Text.color = Color.green;
    }

    public void BattlePhase()
    {
        //Can attack
        DisplayTurn();
        bp_Text.color = Color.green;
    }

    public void ActionPhaseTwo()
    {
        //Can play cards again
        DisplayTurn();
        ap_Two_Text.color = Color.green;
    }

    public void EndPhase()
    {
        //End Turn
        DisplayTurn();
        ep_Text.color = Color.green;
    }

    public void SwitchSides()
    {
        //Other Players Turn
        EndTurn();
    }

    public void NextPhase()
    {
        phase++;
        Phases();
    }

    #endregion

    void DisplayTurn()
    {
        dp_Text.color = Color.black;
        ap_One_Text.color = Color.black;
        bp_Text.color = Color.black;
        ap_Two_Text.color = Color.black;
        ep_Text.color = Color.black;
    }
}
