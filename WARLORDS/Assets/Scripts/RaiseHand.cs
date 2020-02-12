using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RaiseHand : MonoBehaviour/*, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler*/
{
    public GameObject hand = null;
    Animator handAnim = null;
    

    private void Awake()
    {
        if(hand == null)
        {
            hand = GameObject.FindGameObjectWithTag("Hand");
        }
    }

    void Start()
    {
        handAnim = hand.GetComponent<Animator>();
    }

    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    handAnim.SetBool("raiseHand", true);
    //}
    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    handAnim.SetBool("raiseHand", true);
    //}
    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    handAnim.SetBool("raiseHand", true);
    //}
    //public void OnPointerExit(PointerEventData eventData)
    //{
    //    handAnim.SetBool("raiseHand", false);
    //}

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject() == true)
        {
            handAnim.SetBool("raiseHand", true);
        }
        else
        {
            handAnim.SetBool("raiseHand", false);
        }
    }
}
