using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIItemScript : MonoBehaviour, IPointerDownHandler, IPointerClickHandler,
    IPointerUpHandler, IPointerExitHandler, IPointerEnterHandler,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{
	GameObject[] Ui = new GameObject[4];
	
	void Start(){
		
		Ui[0] = GameObject.Find("UIItem1");
		Ui[1] = GameObject.Find("UIItem2");
		Ui[2] = GameObject.Find("UIItem3");
		Ui[3] = GameObject.Find("UIItem4");
		
	}
	
    // Start is called before the first frame update
 public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("Drag Begin");
    }

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("Dragging");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("Drag Ended");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
		
		if(eventData.pointerCurrentRaycast.gameObject == Ui[0]){
			GameObject.Find("InventoryManager").GetComponent<InventoryManagerScript>().removeItem(0);
			Debug.Log("Help");
		}
		if(eventData.pointerCurrentRaycast.gameObject == Ui[1]){
			GameObject.Find("InventoryManager").GetComponent<InventoryManagerScript>().removeItem(1);
		}
		if(eventData.pointerCurrentRaycast.gameObject == Ui[2]){
			GameObject.Find("InventoryManager").GetComponent<InventoryManagerScript>().removeItem(2);
		}
		if(eventData.pointerCurrentRaycast.gameObject == Ui[3]){
			GameObject.Find("InventoryManager").GetComponent<InventoryManagerScript>().removeItem(3);
		}
		
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Mouse Down: " + eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       // Debug.Log("Mouse Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       // Debug.Log("Mouse Exit");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
       // Debug.Log("Mouse Up");
    }

}
