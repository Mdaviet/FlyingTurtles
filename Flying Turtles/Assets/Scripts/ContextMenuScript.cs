using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMenuScript : MonoBehaviour
{
	public bool isActive = false;
	Vector2 mousePos;
	RaycastHit2D hit;
	public GameObject attachedItem;
	public Vector2 MouseOffset = new Vector2(0.0f, 0.0f);
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {

		
		
        
    }
	
	public void Activate(GameObject obj){
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		gameObject.transform.position = new Vector3(mousePos.x + MouseOffset.x, mousePos.y + MouseOffset.y, -5.0f);
		attachedItem = obj;
		isActive = true;
	}
	
	public void Deactivate(){
		
		gameObject.transform.position = new Vector3(100.0f, 100.0f, -5.0f);
		attachedItem = null;
		isActive = false;
		
	}
}
