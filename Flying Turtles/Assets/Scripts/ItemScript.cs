using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
        
	public int reach = 0;
	public int sharp = 0;
	public int flame = 0;
	public int wood = 0;
	public int power = 0;
	public string message = "default";
	Vector3 origPos;
	public bool inInv = false;	
	
	// Start is called before the first frame update
    void Start()
    {
		origPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
