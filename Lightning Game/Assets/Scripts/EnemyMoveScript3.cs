using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript3 : MonoBehaviour
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
		Debug.Log(angle);
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
		
		if(momentum < accelCap){
			momentum = momentum + acceleration * Time.deltaTime;
		}
		else{
			momentum = accelCap;
		}
		
		transform.Translate(new Vector3(1.0f, 0.0f, 0.0f) * momentum * Time.deltaTime);
		//transform.Translate(new Vector3(1.0f, 0.0f, 0.0f) * momentumX * Time.deltaTime);
		//transform.Translate(new Vector3(0.0f, 1.0f, 0.0f) * momentumY * Time.deltaTime);
		
		
		
		
    }
}
