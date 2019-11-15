using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
	RaycastHit2D hit;
	ContextMenuScript CM;
	ContextMenuScript2 CM2;

    // Start is called before the first frame update
    void Start()
    {
       CM = GameObject.Find("ContextMenu").gameObject.GetComponent<ContextMenuScript>();
	   CM2 = GameObject.Find("ContextMenu2").gameObject.GetComponent<ContextMenuScript2>();
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(0)){
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			
			hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			
			if(hit.collider != null){
				
				Debug.Log(hit.collider.name);
				
				if(!CM.isActive && hit.collider.gameObject.GetComponent<ItemScript>() != null){
					CM.Activate(hit.collider.gameObject);
				}
				else if(CM.isActive && CM.attachedItem != hit.collider.gameObject && hit.collider.gameObject != GameObject.Find("ContextMenu").gameObject && hit.collider.gameObject.tag != "Button"){
					CM.Deactivate();
					CM.Activate(hit.collider.gameObject);
					
				}
				if(!CM2.isActive && hit.collider.gameObject.GetComponent<lockObject>() != null){
					CM2.Activate(hit.collider.gameObject);
				}
				else if(CM2.isActive && CM2.attachedItem != hit.collider.gameObject && hit.collider.gameObject != GameObject.Find("ContextMenu2").gameObject && hit.collider.gameObject.tag != "Button2"){
					CM2.Deactivate();
					CM2.Activate(hit.collider.gameObject);
					
				}
				
			
				
				
				switch(hit.collider.gameObject.GetComponent<ClickID>().ID){
					
				case "pickup":
				
					hit.collider.gameObject.GetComponent<PickUpButtonScript>().onClick();
				
					break;
				case "inspect":
				
					hit.collider.gameObject.GetComponent<InspectButtonScript>().onClick();
				
					break;
				case "cancel":
				
					hit.collider.gameObject.GetComponent<CancelButtonScript>().onClick();
					
					break;
				case "use":
					hit.collider.gameObject.GetComponent<UseButtonScript>().onClick();
					break;
					
				case "test1":
					Debug.Log("Clicked " + hit.collider.gameObject.name);
					if(keyValid())
					if(hit.collider.gameObject.GetComponent<Renderer>().material.color != Color.red){
						
						hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
						
					}
					else
						
						hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.white;
					
					
					break;
				
				case "test2":
					Debug.Log("Clicked " + hit.collider.gameObject.name);
					if(hit.collider.gameObject.GetComponent<Renderer>().material.color != Color.green)
						hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
					else
						hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.white;
					break;
				case "background":
					GameObject.Find("moveable").GetComponent<basicMovement>().destination = mousePos2D;
					CM.Deactivate();
					break;
				
				case "default":
					break;
				}
			}
		
			
        }
    }
	
	bool keyValid(){
		GameObject handle = GameObject.Find("moveable");
		lockObject L = hit.collider.gameObject.GetComponent<lockObject>();
		keyObject K = handle.GetComponent<keyObject>();
		
		
		
		if(L != null & K != null){
			if(L.validate(K)){
				return true;
			
			}
			
		}
		return false;
	}
	

	
	
}
