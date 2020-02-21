using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool draggingCard = false;
    TurnSystem turnSystem;
    public Card.CardRole zoneType;

    void Start()
    {
        turnSystem = FindObjectOfType<TurnSystem>();
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
            d.parentToReturnTo = this.transform;
            GetComponent<SpawnCard>().thisCard = d.GetComponent<ThisCard>();
            GetComponent<SpawnCard>().Spawn();
            GraveyardPile.graveyardPile.graveyard.Add(d.gameObject);
            d.parentToReturnTo = GraveyardPile.graveyardPile.transform;
            d.GetComponent<Draggable>().dropped = true;
            turnSystem.NextPhase();
        }
    }
}
