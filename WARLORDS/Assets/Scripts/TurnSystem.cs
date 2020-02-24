using UnityEngine;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    #region Variables
    public static TurnSystem turnSystem;
    public PlayerDeck playerDeck;
    public GameManager gameManager;

    public GameObject playerHand;
    public GameObject turnTextObj;
    public Draggable[] cardsInHand;

    public bool isYourTurn;
    public int turnCount = 0;
    public TextMesh turnCountText;
    public Text turnTimerText;

    public Text dp_Text;
    public Text ap_One_Text;
    public Text bp_Text;
    public Text ap_Two_Text;
    public Text ep_Text;

    public int phase = 0; //0 is Game Start Phase; 1 is Draw Phase 2 is Action Phase One; 3 is Battle Phase; 4 is Action Phase Two; 5 is End Phase;

    public bool gameStarted;
    public bool cardDrawn;
    public bool canPlayCards; //Deteremines whether or not you can play cards in a phase

    public bool beginCountDown = false;
    public float startTime = 30;
    public float currTime = 0;

    Renderer turnTextRend;
    #endregion
    void Awake()
    {
        turnSystem = this;
        phase = 0;
        isYourTurn = true;
        turnCount = 0;
        ResetTimer();
    }

    void Start()
    {
        if(turnTextObj == null)
        {
            turnTextObj = GameObject.FindGameObjectWithTag("TurnIndicator");
            turnTextRend = turnTextObj.GetComponent<Renderer>();
            SetTurnColor();
        }
        else
        {
            turnTextRend = turnTextObj.GetComponent<Renderer>();
            SetTurnColor();
        }
        if (turnCountText == null)
        {
            turnCountText = GameObject.FindGameObjectWithTag("TurnText").GetComponent<TextMesh>();
        }
        Phases();
    }

    void Update()
    {
        turnTimerText.text = currTime.ToString("F0");
        turnCountText.text = turnCount.ToString();
        if (beginCountDown == true)
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

    #region EndingTurns
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
            Phases();
        }
        beginCountDown = true;
        cardDrawn = false;
        SetTurnColor();
    }

    #endregion

    public void Phases()
    {
        switch (phase)
        {
            default:
                GameStartPhase();
                break;

            case 1:
                DrawPhase();
                break;

            case 2:
                ActionPhaseOne();
                break;

            case 3:
                BattlePhase();
                break;

            case 4:
                ActionPhaseTwo();
                break;

            case 5:
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
        CardsInHand();
        //Draw 6 Cards
        if(gameStarted == false)
        {
            gameManager.GameStartPhase();
        }
        else
        {
            phase = 0;
            Invoke("NextPhase", 1);
        }
        canPlayCards = false;
        //Can replace 2 cards -OR- replace entire hand
    }

    public void DrawPhase()
    {
        DisablePhaseColor();
        dp_Text.color = Color.green;
        beginCountDown = true;
        //Draw One Card
        if (cardDrawn == false)
        {
            playerDeck.DrawCard();
            ResetTimer();
            cardDrawn = true;
        }
        if(cardDrawn == true)
        {
            NextPhase();
            Phases();
        }

    }

    public void ActionPhaseOne()
    {
        //Play or move Unit cards
        //Play Strategy Card
        //Play Field Card
        beginCountDown = true;

        beginCountDown = true;

        beginCountDown = true;

        cardDrawn = false;
        canPlayCards = true;
        CardsInHand();
        DisablePhaseColor();
        ap_One_Text.color = Color.green;
    }

    public void BattlePhase()
    {
        canPlayCards = false;
        CardsInHand();
        //Can attack
        DisablePhaseColor();
        bp_Text.color = Color.green;
    }

    public void ActionPhaseTwo()
    {
        //Can play cards again
        cardDrawn = false;
        canPlayCards = true;
        CardsInHand();
        DisablePhaseColor();
        ap_Two_Text.color = Color.green;
    }

    public void EndPhase()
    {
        //End Turn
        DisablePhaseColor();
        ep_Text.color = Color.green;
        Invoke("NextPhase", 1);
    }

    public void SwitchSides()
    {
        //Other Players Turn
        beginCountDown = false;
        EndTurn();
        ResetTimer();
    }

    #endregion
    public void NextPhase()
    {
        phase++;
        Phases();
    }

    void DisablePhaseColor()
    {
        dp_Text.color = Color.black;
        ap_One_Text.color = Color.black;
        bp_Text.color = Color.black;
        ap_Two_Text.color = Color.black;
        ep_Text.color = Color.black;
    }

    void CardsInHand()
    {
        cardsInHand = playerHand.transform.GetComponentsInChildren<Draggable>();
        foreach(Draggable d in cardsInHand)
        {
            if(canPlayCards == false)
            {
                d.enabled = false;
            }
            else
            {
                d.enabled = true;
            }
        }
    }

    void SetTurnColor()
    {
        if (isYourTurn == true)
        {
            turnTextRend.material = Resources.Load<Material>("PlayerTileMat");
        }
        else
        {
            turnTextRend.material = Resources.Load<Material>("EnemyTileMat");
        }
    }
}
