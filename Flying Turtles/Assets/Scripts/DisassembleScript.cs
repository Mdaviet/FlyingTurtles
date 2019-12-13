using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisassembleScript : MonoBehaviour
{
	
	public GameObject comp1;
	public GameObject comp2;
	
	public float x1Off = 0.0f;
	public float x2Off = 0.0f;
	public float y1Off = 0.0f;
	public float y2Off = 0.0f;
	
    // Start is called before the first frame update
    void Start()
    {
		
        
    }
	
	public void CallItems(){
		Vector3 curpos = gameObject.transform.position;
		if(comp1 != null)
		comp1.transform.position = new Vector3(curpos.x + x1Off, curpos.y + y1Off, curpos.z);
		if(comp2 != null)
		comp2.transform.position = new Vector3(curpos.x+x2Off, curpos.y - y2Off, curpos.z);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
