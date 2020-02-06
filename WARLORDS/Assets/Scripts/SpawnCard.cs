using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnCard : DropZone
{
    public GameObject unit;
    public Transform spawnPoint;

    public override void OnDrop(PointerEventData eventData)
    {
        base.OnDrop(eventData);
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        GameObject unitSpawning = Instantiate(unit, spawnPoint.position, spawnPoint.rotation);

        if (d.GetComponent<CardStats>())
        {
            unitSpawning.GetComponent<TacticsMove>().move = d.GetComponent<CardStats>()._actionsPoints;
        }

    }
}