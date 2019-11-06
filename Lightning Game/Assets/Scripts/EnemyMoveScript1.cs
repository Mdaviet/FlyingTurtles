using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript1 : MonoBehaviour
{
   
    public Vector2 destination;
	Vector2 currentPos;
	public float distanceY;
	public float distanceX;
	float angle;
	public Vector2 ratio;
	float XRatio;
	float YRatio;
	
	public float momentumX;
	public float momentumY;
	float totalMomentum;
	public float acceleration = 0.1f;
	public float accelCap = 5.0f;
   
   
    void Start()
    {
		destination = GameObject.Find("Player").GetComponent<PlayerMoveScript>().currentPos;
        currentPos = new Vector2(transform.position.x, transform.position.y);
		distanceX = destination.x - currentPos.x;
		distanceY = destination.y - currentPos.y;
		angle = Mathf.Atan2(distanceY , distanceX);
		Debug.Log(angle);
        
    }

    // Update is called once per frame
    void Update()
    {
		destination = GameObject.Find("Player").GetComponent<PlayerMoveScript>().currentPos;
        currentPos = new Vector2(transform.position.x, transform.position.y);
		distanceX = destination.x - currentPos.x;
		distanceY = destination.y - currentPos.y;
		angle = Mathf.Atan2(distanceY , distanceX);
        angle = angle * (180.0f/Mathf.PI);
		ratio.x = Mathf.Cos(angle* (Mathf.PI/180.0f));
		ratio.y = Mathf.Sin(angle* (Mathf.PI/180.0f));
		totalMomentum = Mathf.Sqrt((momentumX*momentumX) + (momentumY*momentumY));
		
		transform.eulerAngles = new Vector3(0.0f, 0.0f, angle);
		
		
		if(distanceX > 0){
			
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

		if(distanceX < 0){
			
			if(-momentumX < accelCap){
					momentumX = momentumX - acceleration * Time.deltaTime;
				}
				
		}
		else if(-momentumX > 0.0f){
			momentumX = momentumX + acceleration * Time.deltaTime;
			if(momentumX > 0)
				momentumX = 0;
		
		}
		
		if(distanceY > 0){
			
			if(momentumY < accelCap){
					momentumY = momentumY + acceleration * Time.deltaTime;
				}
				
		}
		else if(momentumY > 0.0f){
			momentumY = momentumY - acceleration * Time.deltaTime;
			if(momentumY < 0)
				momentumY = 0;
		
		}
		
		if(distanceY < 0){
			
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
