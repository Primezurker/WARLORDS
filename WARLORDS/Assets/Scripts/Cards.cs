using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Cards : ScriptableObject
{
    public GameObject unit = null;
    public string cardName = "";
    public int resourceCost = 0;
    public Sprite cardSprite = null;
    public Color cardColor;
    public int actionPoints = 1;
    public string cardDescription = "";
    public int cardAttack = 0;
    public int cardHealth = 0;
    public enum CardFaction { ROMANS, GREEKS, MONGOLS, CHINESE, NORSE, INDIANS };
    public enum CardType { MELEE, RANGED, SIEGE, GRAND, TACTICS, TRAP, AUXILIARY, TERRAIN, FORTIFICATION };
    public CardFaction typeOfFaction;
    public CardType typeOfCard;
}