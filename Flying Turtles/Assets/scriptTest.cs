using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTest : MonoBehaviour
{
	

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
			
			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			
			if(hit.collider != null){
				
				switch(hit.collider.gameObject.GetComponent<ClickID>().ID){
					
				case 0:
					Debug.Log("Clicked " + hit.collider.gameObject.name);
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
	

	
	
}
