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
			
			parent.GetComponent<ContextMenuScript2>().attachedItem.transform.position = new Vector3(100.0f, 100.0f, 0.0f);
			GameObject.Find("InspectMessage").GetComponent<InspectMessageScript>().UpdateMessage(Lock.useSuccsess);
			
		}
		else {
			GameObject.Find("InspectMessage").GetComponent<InspectMessageScript>().UpdateMessage(Lock.useFail);
		}
		
		parent.GetComponent<ContextMenuScript2>().Deactivate();
	}
}
