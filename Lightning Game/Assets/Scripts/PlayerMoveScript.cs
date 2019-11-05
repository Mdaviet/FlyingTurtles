using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoveScript : MonoBehaviour
{
	
	public Vector2 destination;
	public float speed = 1.0f;
	public float tolerance = 0.05f;
	Vector2 currentPos;
	Vector3 go;
	float distanceY;
	float distanceX;
	float angle;
	public Vector2 ratio;
	float XRatio;
	float YRatio;
	
	public float momentumX;
	public float momentumY;
	public float acceleration = 0.1f;
	public float accelCap = 5.0f;
	

	
    // Start is called before the first frame update
    void Start()
    {
		//destination = new Vector2(3.0f, 2.5f);
		destination = GameObject.Find("MouseHelper").GetComponent<MouseHelperScript>().mousePos2D;
        currentPos = new Vector2(transform.position.x, transform.position.y);
		distanceX = destination.x - currentPos.x;
		distanceY = destination.y - currentPos.y;
		angle = Mathf.Atan2(distanceY , distanceX);
		Debug.Log(angle);
		
		
    }

    // Update is called once per frame
    void Update()
    {
		destination = GameObject.Find("MouseHelper").GetComponent<MouseHelperScript>().mousePos2D;
		KeyBoardHelperScript kbh = GameObject.Find("KeyBoardHelper").GetComponent<KeyBoardHelperScript>();
		currentPos = new Vector2(transform.position.x, transform.position.y);
		distanceX = destination.x - currentPos.x;
		distanceY = destination.y - currentPos.y;
		angle = Mathf.Atan2(distanceY , distanceX);
		angle = angle * (180.0f/Mathf.PI);
		ratio.x = Mathf.Cos(angle* (Mathf.PI/180.0f));
		ratio.y = Mathf.Sin(angle* (Mathf.PI/180.0f));
		Vector3 go = new Vector3(ratio.x, ratio.y, 0);
		
		transform.eulerAngles = new Vector3(0.0f, 0.0f, angle);
		
		
		//Right Movement

		
		if(kbh.rightKeyHeld){
			
			if(momentumX < accelCap){
					momentumX = momentumX + acceleration * Time.deltaTime;
				}
				
		}
		else if(momentumX > 0.0f){
			momentumX = momentumX - acceleration * Time.deltaTime;
			if(momentumX < 0)
				momentumX = 0;
		
		}
		
		//Left Movement

		if(kbh.leftKeyHeld){
			
			if(-momentumX < accelCap){
					momentumX = momentumX - acceleration * Time.deltaTime;
				}
				
		}
		else if(-momentumX > 0.0f){
			momentumX = momentumX + acceleration * Time.deltaTime;
			if(momentumX > 0)
				momentumX = 0;
		
		}
		
		if(kbh.upKeyHeld){
			
			if(momentumY < accelCap){
					momentumY = momentumY + acceleration * Time.deltaTime;
				}
				
		}
		else if(momentumY > 0.0f){
			momentumY = momentumY - acceleration * Time.deltaTime;
			if(momentumY < 0)
				momentumY = 0;
		
		}
		
		if(kbh.downKeyHeld){
			
			if(-momentumY < accelCap){
					momentumY = momentumY - acceleration * Time.deltaTime;
				}
				
		}
		else if(-momentumY > 0.0f){
			momentumY = momentumY + acceleration * Time.deltaTime;
			if(momentumY > 0)
				momentumY = 0;
		
		}
		
		
		
		
		
		transform.Translate(new Vector3(1.0f, 0.0f, 0.0f) * momentumX * Time.deltaTime, Space.World);
		transform.Translate(new Vector3(0.0f, 1.0f, 0.0f) * momentumY * Time.deltaTime, Space.World);
		
		
			
        
    }

	
	
}
