using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManagerScript : MonoBehaviour
{
	
	public GameObject i1, i2, i3, i4;
	int totalItems = 0;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public bool addItem(GameObject item){
		if(totalItems < 4){
			if(i1 == null){
				i1 = item;
			}
			else if(i2 == null){
				i2 = item;
			}
			else if(i3 == null){
				i3 = item;
				
			}
			else {
				i4 = item;
				
			}
			
			
		}
		else{
			return false;
		}
		return true;
	}
	
}
