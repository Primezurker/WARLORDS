﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler/*, IPointerEnterHandler, IPointerExitHandler*/
{
    public Transform parentToReturnTo = null;
    public Transform placeholderParent = null;
    GameObject placeholder = null;
    CanvasGroup canvasGroup;
    public Card.CardRole cardRole;
    public bool dropped = false;
    public Vector3 zoomSize;

    //Animation
    public GameObject hand = null;
    //Animator handAnim = null;
    
    void Awake()
    {
        if (hand == null)
        {
            hand = GameObject.FindGameObjectWithTag("Hand");
        }
        canvasGroup = GetComponent<CanvasGroup>();
    }

    void Start()
    {
        //handAnim = hand.GetComponent<Animator>();
        parentToReturnTo = this.transform.parent;
        placeholderParent = parentToReturnTo;
    }

    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    //transform.localScale += zoomSize; //Adjust values to enlarge or shrink the zoom
    //    //handAnim.SetBool("raiseHand", true);
    //}
    //public void OnPointerExit(PointerEventData eventData)
    //{
    //    //transform.localScale = new Vector3(1, 1, 1); //To set transform back
    //    //handAnim.SetBool("raiseHand", false);
    //}

    public void OnBeginDrag(PointerEventData eventData)
    {
        //handAnim.SetBool("draggingCard", true);
        //transform.localScale = new Vector3(1, 1, 1); //To set transform back
        placeholder = new GameObject();
        placeholder.transform.SetParent(this.transform.parent);
        parentToReturnTo = this.transform.parent;

        LayoutElement le = placeholder.AddComponent<LayoutElement>();
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.flexibleWidth = 0;
        le.flexibleHeight = 0;

        placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
        placeholderParent = parentToReturnTo;
        this.transform.SetParent(this.transform.parent.parent); //Hard-coding here. Optimize later

        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //transform.localScale = new Vector3(1, 1, 1); //To set transform back
        this.transform.position = eventData.position;
        if(placeholder.transform.parent != placeholderParent)
        {
            placeholder.transform.SetParent(placeholderParent);
        }
        int newSiblingIndex = placeholder.transform.GetSiblingIndex();

        for(int i = 0; i < placeholderParent.childCount; i++)
        {
            if(this.transform.position.x < placeholderParent.GetChild(i).position.x)
            {
                newSiblingIndex = i;
                if(placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                {
                    newSiblingIndex--;
                }
                break;
            }
        }
        //handAnim.SetBool("draggingCard", true);
        placeholder.transform.SetSiblingIndex(newSiblingIndex);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //transform.localScale = new Vector3(1, 1, 1); //To set transform back
        this.transform.SetParent(parentToReturnTo);
        this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
        if(dropped == false || this.transform.parent.tag == "Hand")
        {
            canvasGroup.blocksRaycasts = true;
        }
        else
        {
            canvasGroup.blocksRaycasts = false;
        }
        Destroy(placeholder);
        //handAnim.SetBool("draggingCard", false);
    }
}