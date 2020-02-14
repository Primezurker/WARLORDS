using UnityEngine;

public class SpawnCard : MonoBehaviour
{
    public GameObject cardToSpawn;
    public Transform pieceLocation;
    public ThisCard thisCard;

    public void Spawn()
    {
        GameObject spawningCard = Instantiate(cardToSpawn, pieceLocation.position, pieceLocation.rotation);
        Stats spawnedCardStats = spawningCard.GetComponent<Stats>();
        spawnedCardStats.attack = thisCard.cardAttack;
        spawnedCardStats.defense = thisCard.cardHealth;
        spawnedCardStats.actionPoints = thisCard.actionPoints;
    }
}
