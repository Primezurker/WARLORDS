using UnityEngine;

[RequireComponent(typeof(CardDisplay))]
public class CardStats : MonoBehaviour
{
    Cards cards;
    //public int _resourceCost = 0;
    public int _actionsPoints = 0;
    public int _cardAttack = 0;
    public int _cardHealth = 0;
    public GameObject _unit;

    void Start()
    {
        cards = GetComponent<CardDisplay>().cards;

        //_resourceCost = cards.resourceCost;
        _actionsPoints = cards.actionPoints;
        _cardAttack = cards.cardAttack;
        _cardHealth = cards.cardHealth;
        _unit = cards.unit;
    }
}
