using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinStepScript : MonoBehaviour
{
	

	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	public void Activate(){
		GameObject.Find("moveable").GetComponent<keyObject>().sharp += 50;
	}
	

    // Update is called once per frame
    void Update()
    {
        
    }
}
