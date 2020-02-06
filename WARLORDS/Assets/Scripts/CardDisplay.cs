using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    [Header("Display Info")]
    public Cards cards;
    public Text cardType = null;
    public Text cardName = null;
    public Text resourceCost = null;
    public Image cardImage = null;
    public Image cardColor;
    public Text cardFaction = null;
    public Text actionPoints = null;
    public Text cardDescription = null;
    public Text cardAttack = null;
    public Text cardHealth = null;

    void Awake()
    {
        cardType.text = cards.typeOfCard.ToString();
        cardName.text = cards.cardName;
        resourceCost.text = cards.resourceCost.ToString();
        cardImage.sprite = cards.cardSprite;
        cardColor.color = cards.cardColor;
        cardFaction.text = cards.typeOfFaction.ToString();
        actionPoints.text = cards.actionPoints.ToString();
        cardDescription.text = cards.cardDescription;
        cardAttack.text = cards.cardAttack.ToString();
        cardHealth.text = cards.cardHealth.ToString();
    }
}
