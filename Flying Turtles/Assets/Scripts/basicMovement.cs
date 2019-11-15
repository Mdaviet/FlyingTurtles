using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class basicMovement : MonoBehaviour
{
	
	public Vector2 destination;
	public float speed = 1.0f;
	public float tolerance = 0.05f;
	Vector2 currentPos;
	Vector3 go;
	float distanceY;
	float distanceX;
	float angle;
	float XRatio;
	float YRatio;

	
	
	
    // Start is called before the first frame update
    void Start()
    {
		//destination = new Vector2(3.0f, 2.5f);
        currentPos = new Vector2(transform.position.x, transform.position.y);
		distanceX = destination.x - currentPos.x;
		distanceY = destination.y - currentPos.y;
		angle = Mathf.Atan2(distanceY , distanceX);
		Debug.Log(angle);
		
		
    }

    // Update is called once per frame
    void Update()
    {
		currentPos = new Vector2(transform.position.x, transform.position.y);
		distanceX = destination.x - currentPos.x;
		distanceY = destination.y - currentPos.y;
		angle = Mathf.Atan2(distanceY , distanceX);
		XRatio = Mathf.Cos(angle);
		YRatio = Mathf.Sin(angle);
		Vector3 go = new Vector3(XRatio, YRatio, 0);
		if((Mathf.Abs(distanceY) >= tolerance) || (Mathf.Abs(distanceX) >= tolerance)){
			
				
				
				
				transform.Translate(go * speed * Time.deltaTime);
				
				
				
			
			
		}
		else{
			transform.position = destination;
		
		}
		
		
		
			
        
    }


	
}
