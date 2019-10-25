using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTest : MonoBehaviour
{
	RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(0)){
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			
			hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			
			if(hit.collider != null){
				
				switch(hit.collider.gameObject.GetComponent<ClickID>().ID){
					
				case 0:
					Debug.Log("Clicked " + hit.collider.gameObject.name);
					if(keyValid())
					if(hit.collider.gameObject.GetComponent<Renderer>().material.color != Color.red)
						
						hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
					else
						
						hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.white;
					
					
					break;
				
				case 1:
					Debug.Log("Clicked " + hit.collider.gameObject.name);
					if(hit.collider.gameObject.GetComponent<Renderer>().material.color != Color.green)
						hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
					else
						hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.white;
					break;
					
				}
			}
			else{
				GameObject.Find("moveable").GetComponent<basicMovement>().destination = mousePos2D;
				
				
			}
			
        }
    }
	
	bool keyValid(){
		GameObject handle = GameObject.Find("moveable");
		lockObject L = hit.collider.gameObject.GetComponent<lockObject>();
		keyObject K = handle.GetComponent<keyObject>();
		
		
		
		if(L != null & K != null){
			if(L.validate(K)){
				return true;
			
			}
			
		}
		return false;
	}
	

	
	
}
