using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPreserverScript : MonoBehaviour
{
	public GameObject player;
	public GameObject Canvas;
	public GameObject[] UIItems = new GameObject[4]; 
	public GameObject ClickManager;
	public GameObject ConMenu1;
	public GameObject ConMenu2;
	public GameObject Camera;
	public GameObject InventoryManager;
	public GameObject EventSystem;


	
	
    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.Find("moveable");
		Canvas = GameObject.Find("Canvas");
		ClickManager = GameObject.Find("ClickManager");
		ConMenu1 = GameObject.Find("ContextMenu");
		ConMenu2 = GameObject.Find("ContextMenu2");
		EventSystem = GameObject.Find("EventSystem");
	
		InventoryManager = GameObject.Find("InventoryManager");
		DontDestroyOnLoad(gameObject);
		DontDestroyOnLoad(player);
		DontDestroyOnLoad(Canvas);
		DontDestroyOnLoad(ClickManager);
		DontDestroyOnLoad(ConMenu1);
		DontDestroyOnLoad(ConMenu2);
		DontDestroyOnLoad(InventoryManager);
		DontDestroyOnLoad(EventSystem);
		
		
		

        
    }
	
	
	public void PreserveItems(){
		
		GameObject[] items;
		items	= GameObject.Find("InventoryManager").GetComponent<InventoryManagerScript>().i;
		for(int i = 0; i < items.Length; i++){
			if(items[i] != null){
				DontDestroyOnLoad(items[i]);
			}
		}
		
		
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
