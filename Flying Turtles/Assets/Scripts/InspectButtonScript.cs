using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectButtonScript : MonoBehaviour
{
 public GameObject parent;
	
    // Start is called before the first frame update
	public ItemScript item;
	public lockObject item2;
	
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void onClick(){
		if(parent.GetComponent<ContextMenuScript>() != null)
			item = parent.GetComponent<ContextMenuScript>().attachedItem.GetComponent<ItemScript>();
		if(parent.GetComponent<ContextMenuScript2>() != null)
			item2 = parent.GetComponent<ContextMenuScript2>().attachedItem.GetComponent<lockObject>();
		
		string msg = "This object has no message";
		
		if(item != null){
			
			msg = item.message;
			
		}
		
		if(item2 != null){
			msg = item2.message;
			
		}

		
		InspectMessageScript message = GameObject.Find("InspectMessage").GetComponent<InspectMessageScript>();
		message.UpdateMessage(msg);
		
		
		if(parent.GetComponent<ContextMenuScript>() != null)
			parent.GetComponent<ContextMenuScript>().Deactivate();
		if(parent.GetComponent<ContextMenuScript2>() != null)
			parent.GetComponent<ContextMenuScript2>().Deactivate();
	}
	
}
