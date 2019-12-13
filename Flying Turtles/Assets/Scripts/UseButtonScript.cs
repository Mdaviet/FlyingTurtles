using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseButtonScript : MonoBehaviour
{
public GameObject parent;
public keyObject key;
	
    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
		key = GameObject.Find("moveable").GetComponent<keyObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void onClick(){
		lockObject Lock = parent.GetComponent<ContextMenuScript2>().attachedItem.GetComponent<lockObject>();
		
		
		if(Lock.validate(key)){
			
			//parent.GetComponent<ContextMenuScript2>().attachedItem.transform.position = new Vector3(100.0f, 100.0f, 0.0f);
			Lock.Activate();

			GameObject.Find("InspectMessage").GetComponent<InspectMessageScript>().UpdateMessage(Lock.useSuccsess);
			
			if(parent.GetComponent<ContextMenuScript2>().attachedItem.GetComponent<ExitScript>() != null){
			
				
				parent.GetComponent<ContextMenuScript2>().attachedItem.GetComponent<ExitScript>().Exit();
				
			}
			if(parent.GetComponent<ContextMenuScript2>().attachedItem.GetComponent<DisassembleScript>() != null){
				
				parent.GetComponent<ContextMenuScript2>().attachedItem.GetComponent<DisassembleScript>().CallItems();
				parent.GetComponent<ContextMenuScript2>().attachedItem.transform.position = new Vector3(100f, 100f, 0f);
				
			}
			
			
		}
		else {
			GameObject.Find("InspectMessage").GetComponent<InspectMessageScript>().UpdateMessage(Lock.useFail);
		}
		
		
		
		
		parent.GetComponent<ContextMenuScript2>().Deactivate();
	}
}
