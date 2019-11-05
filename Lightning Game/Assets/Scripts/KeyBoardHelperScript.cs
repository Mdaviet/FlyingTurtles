using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardHelperScript : MonoBehaviour
{
	
	public bool rightKeyHeld = false;
	public bool leftKeyHeld = false;
	public bool upKeyHeld = false;
	public bool downKeyHeld = false;
	public bool spaceKeyHeld = false;
	


    // Update is called once per frame
    void Update()
    {
		//Right
		if(Input.GetKeyDown(KeyCode.D)){
			rightKeyHeld = true;

		}
		
		if(Input.GetKeyUp(KeyCode.D)){
			rightKeyHeld = false;

		}
		
		//Left
		if(Input.GetKeyDown(KeyCode.A)){
			leftKeyHeld = true;

		}
		
		if(Input.GetKeyUp(KeyCode.A)){
			leftKeyHeld = false;

		}
		
		//Up
		if(Input.GetKeyDown(KeyCode.W)){
			upKeyHeld = true;

		}
		
		if(Input.GetKeyUp(KeyCode.W)){
			upKeyHeld = false;

		}
		
		
		//Down
		if(Input.GetKeyDown(KeyCode.S)){
			downKeyHeld = true;

		}
		
		if(Input.GetKeyUp(KeyCode.S)){
			downKeyHeld = false;

		}
		
		//Space
		if(Input.GetKeyDown(KeyCode.Space)){
			spaceKeyHeld = true;

		}
		
		if(Input.GetKeyUp(KeyCode.Space)){
			spaceKeyHeld = false;

		}
		
        
    }
}
