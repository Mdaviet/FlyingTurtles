using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisassembleScript : MonoBehaviour
{
	
	public GameObject comp1;
	public GameObject comp2;
	
    // Start is called before the first frame update
    void Start()
    {
		
        
    }
	
	public void CallItems(){
		Vector3 curpos = gameObject.transform.position;
		comp1.transform.position = new Vector3(curpos.x-1.0f, curpos.y, curpos.z);
		comp2.transform.position = new Vector3(curpos.x+1.0f, curpos.y, curpos.z);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
