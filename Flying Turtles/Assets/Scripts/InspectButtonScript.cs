using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectButtonScript : MonoBehaviour
{
 public GameObject parent;
	
    // Start is called before the first frame update
	public ItemScript item;

	
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void onClick(){
		
		item = parent.GetComponent<ContextMenuScript>().attachedItem.GetComponent<ItemScript>();
		string msg = "This object has no message";
		
		if(item != null){
			
			msg = item.message;
			
		}

		
		InspectMessageScript message = GameObject.Find("InspectMessage").GetComponent<InspectMessageScript>();
		message.UpdateMessage(msg);
		
		parent.GetComponent<ContextMenuScript>().Deactivate();
		
	}
	
}
