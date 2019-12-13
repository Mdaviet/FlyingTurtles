using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpButtonScript : MonoBehaviour
{
	public GameObject parent;
	InventoryManagerScript Inventory;
	
    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
		Inventory = GameObject.Find("InventoryManager").GetComponent<InventoryManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void onClick(){
	
		GameObject item = parent.GetComponent<ContextMenuScript>().attachedItem;
		bool hasDepend = item.GetComponent<ItemScript>().depend != null;
	
		if(!hasDepend || item.GetComponent<ItemScript>().depend.GetComponent<lockObject>().activated){
			if(!Inventory.addItem(item)){
					GameObject.Find("InspectMessage").GetComponent<InspectMessageScript>().UpdateMessage("Too many items in inventory");
					return;
				}
				
				//transform.position = new Vector3(100.0f, 100.0f, 0.0f);
				item.transform.position = new Vector3(100.0f, 100.0f, 0.0f);
				item.GetComponent<ItemScript>().inInv = true;
				
				
				parent.GetComponent<ContextMenuScript>().Deactivate();
					
			}
			else{
				GameObject.Find("InspectMessage").GetComponent<InspectMessageScript>().UpdateMessage(item.GetComponent<ItemScript>().unavaliableMessage);
				parent.GetComponent<ContextMenuScript>().Deactivate();
				
			}
			
		
	}
}
