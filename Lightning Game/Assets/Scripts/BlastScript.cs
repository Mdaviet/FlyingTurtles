using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastScript : MonoBehaviour
{
	
	public int damage = 1;
	private float flashInterval = 0.5f;
	private float timer = 0.0f;
	public int frame = 0;

	
    // Start is called before the first frame update
    void Start()
    {
		
		Destroy(gameObject, 5);
        
    }
	
	void Update(){
		
		//Fix Later
		/*timer += Time.deltaTime;
		
		if(timer >= flashInterval){
			timer = 0.0f;
			if(frame == 0){
				 gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("Textures/Blast1", typeof(Sprite)) as Sprite;
				 frame = 1;
			}
			else{
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("Textures/Blast2", typeof(Sprite)) as Sprite;
				frame = 0;
			}
			
			
			
		}
		*/
		
		
	}
}


