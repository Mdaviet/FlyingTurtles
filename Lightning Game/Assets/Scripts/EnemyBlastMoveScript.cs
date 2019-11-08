using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlastMoveScript : MonoBehaviour
{
	
	public Vector2 angle;
	public float speed = 1.0f;
	
    // Start is called before the first frame update
    void Start()
    {
		
		//angle = transform.parent.gameObject.GetComponent<EnemyMoveScript2>().ratio;
		
		
        
    }

    // Update is called once per frame
    void Update()
    {
		
		transform.Translate(new Vector3(1.0f ,0.0f ,0.0f) * speed * Time.deltaTime);
		
        
    }
}
