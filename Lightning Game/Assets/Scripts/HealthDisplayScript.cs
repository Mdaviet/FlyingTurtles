using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplayScript : MonoBehaviour
{
 
	public Text MyText;
    // Start is called before the first frame update
    void Start()
    {	
		MyText = gameObject.GetComponent<Text>();
        MyText.text = "HEALTH: 10";
    }

    // Update is called once per frame
    void Update()
    {
		
       
    }
	
	public void HealthUpdate(int health){
		
		 MyText.text = "HEALTH: " + health;
	}
}
