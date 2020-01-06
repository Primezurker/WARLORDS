using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Cards : ScriptableObject
{
    public Sprite cardSprite;
    public Sprite rarity;
    public string cardName;
    public string cardText;
    public int cardAttack = 0;
    public int cardDefense = 0; //Health
}
