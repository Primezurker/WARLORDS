using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public bool draggingCard = false;
    public GraveyardPile graveyard;
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
        if(d != null)
        {
            d.parentToReturnTo = this.transform;
            GetComponent<SpawnCard>().thisCard = d.GetComponent<ThisCard>();
            GetComponent<SpawnCard>().Spawn();
            graveyard.graveyard.Add(d.gameObject);
            //graveyard.graveyard.Add(d.GetComponent<ThisCard>());
            d.parentToReturnTo = graveyard.transform;
            d.GetComponent<Draggable>().dropped = true;
        }
    }
}
