using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastMoveScript : MonoBehaviour
{
	
	public Vector2 angle;
	public float speed = 1.0f;
	
    // Start is called before the first frame update
    void Start()
    {
		
		angle = GameObject.Find("Player").GetComponent<PlayerMoveScript>().ratio;
		
		
        
    }

    // Update is called once per frame
    void Update()
    {
		
		transform.Translate(new Vector3(angle.x, angle.y ,0.0f) * speed * Time.deltaTime);
		
        
    }
}
