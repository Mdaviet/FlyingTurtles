using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButtonScript : MonoBehaviour
{
 public GameObject parent;
	
    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void onClick(){
		parent.GetComponent<ContextMenuScript>().Deactivate();
		
	}
}
