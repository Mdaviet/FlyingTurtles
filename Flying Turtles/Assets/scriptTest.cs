using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTest : MonoBehaviour
{
	

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hewwo!");
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(0)){
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
			
			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			
			if(hit.collider != null){
				Debug.Log("Clicked " + hit.collider.gameObject.name);
				if(hit.collider.gameObject.GetComponent<Renderer>().material.color != Color.red)
					hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
				else
					hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.white;
			}
			
        }
    }
	

	
	
}
