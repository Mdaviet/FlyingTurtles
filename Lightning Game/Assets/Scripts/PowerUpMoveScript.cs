using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMoveScript : MonoBehaviour
{
   
    public Vector2 destination;
	Vector2 currentPos;
	public float distanceY;
	public float distanceX;
	float angle;
	public Vector2 ratio;
	float XRatio;
	float YRatio;
	
//	public float momentumX;
//	public float momentumY;
	public float momentum;
	float totalMomentum;
	public float acceleration;
	public float accelCap;
	public Vector2 direction;
   
   
    void Start()
    {
		acceleration = GameObject.Find("DifficultyController").GetComponent<DifficultyControllerScript>().speed;
		accelCap = GameObject.Find("DifficultyController").GetComponent<DifficultyControllerScript>().speed;
		destination = GameObject.Find("Player").GetComponent<PlayerMoveScript>().currentPos;
        currentPos = new Vector2(transform.position.x, transform.position.y);
		distanceX = destination.x - currentPos.x;
		distanceY = destination.y - currentPos.y;
		angle = Mathf.Atan2(distanceY , distanceX);
		transform.eulerAngles = new Vector3(0.0f, 0.0f, angle * 180.0f/Mathf.PI);
		if(transform.position.x < -10.7f){
			direction = new Vector2(3.0f, 0.0f);
		}
		if(transform.position.x > 10.7f){
			direction = new Vector2(-3.0f, 0.0f);
		}
		if(transform.position.y < -5f){
			direction = new Vector2(0.0f, 3.0f);
		}
		if(transform.position.y > 5){
			direction = new Vector2(0.0f, -3.0f);
		}
		
		Destroy(gameObject, 20);
        
    }

    // Update is called once per frame
    void Update()
    {
		//destination = GameObject.Find("Player").GetComponent<PlayerMoveScript>().currentPos;
        currentPos = new Vector2(transform.position.x, transform.position.y);
		distanceX = destination.x - currentPos.x;
		distanceY = destination.y - currentPos.y;
		angle = Mathf.Atan2(distanceY , distanceX);
        angle = angle * (180.0f/Mathf.PI);
		ratio.x = Mathf.Cos(angle* (Mathf.PI/180.0f));
		ratio.y = Mathf.Sin(angle* (Mathf.PI/180.0f));
		//totalMomentum = Mathf.Sqrt((momentumX*momentumX) + (momentumY*momentumY));
		transform.eulerAngles = new Vector3(0.0f, 0.0f, transform.eulerAngles.z + 3f);
	
		
		transform.Translate(new Vector3(direction.x, direction.y, 0.0f) * Time.deltaTime, Space.World);
		//transform.Translate(new Vector3(1.0f, 0.0f, 0.0f) * momentumX * Time.deltaTime);
		//transform.Translate(new Vector3(0.0f, 1.0f, 0.0f) * momentumY * Time.deltaTime);
		
		
		
		
    }
}
