using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool draggingCard = false;
    TurnSystem turnSystem;
    public Card.CardRole zoneType;

    Image terrainImage;
    bool isTerrain = false;

    void Start()
    {
        turnSystem = FindObjectOfType<TurnSystem>();
        if(gameObject.tag == "TerrainZone")
        {
            isTerrain = true;
        }
        terrainImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(eventData.pointerDrag == null)
        {
            return;
        }
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null)
        {
            d.placeholderParent = this.transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(eventData.pointerDrag == null)
        {
            return;
        }
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null && d.placeholderParent == this.transform)
        {
            d.placeholderParent = d.parentToReturnTo;
        }
    }

    public virtual void OnDrop(PointerEventData eventData)
    {
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null && d.cardRole == zoneType && gameObject.tag != "Hand")
        {
            if (zoneType == Card.CardRole.UNIT)
            {
                d.parentToReturnTo = this.transform;
                GetComponent<SpawnCard>().thisCard = d.GetComponent<ThisCard>();
                GetComponent<SpawnCard>().Spawn();
                GraveyardPile.graveyardPile.graveyard.Add(d.gameObject);
                d.parentToReturnTo = GraveyardPile.graveyardPile.transform;
                d.GetComponent<Draggable>().dropped = true;
                turnSystem.NextPhase();
            }
            if(zoneType == Card.CardRole.FIELD)
            {
                if (isTerrain)
                {
                    d.parentToReturnTo = this.transform;
                    terrainImage.sprite = d.GetComponent<ThisCard>().cardImage.sprite;
                    GraveyardPile.graveyardPile.graveyard.Add(d.gameObject);
                    d.parentToReturnTo = GraveyardPile.graveyardPile.transform;
                    d.GetComponent<Draggable>().dropped = true;
                    turnSystem.NextPhase();
                }
                else
                {

                }
            }
            if(zoneType == Card.CardRole.STRATEGY)
            {

            }
        }
    }
}
