using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TextAnimation : MonoBehaviour, IPointerEnterHandler
{
    public Animator anim;

    public void OnPointerEnter(PointerEventData eventData)
    { 
        anim.Play("TextAnimation");
        Debug.Log("textanmation");
    } 

}
