using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
	
	public string nextScene;
	bool firstTime = false;
	
    // Start is called before the first frame update
    void Start()
    {
		
		
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	

	
	public void Exit(){
		GameObject.Find("ObjectPreserver").GetComponent<ObjectPreserverScript>().PreserveItems();
		SceneManager.LoadScene(nextScene);
		GameObject.Find("ObjectPreserver").GetComponent<ObjectPreserverScript>().UnPreserveItems();
		
	}
	
	
}
