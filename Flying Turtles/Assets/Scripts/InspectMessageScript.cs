using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectMessageScript : MonoBehaviour
{
	public Text MyText;
	public float duration = 5.0f;
	float timer = 0.0f;
	bool active = false;
    // Start is called before the first frame update
    void Start()
    {
		MyText = gameObject.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
		if(active){
			timer += Time.deltaTime;
		}
        if(timer >= duration){
			MyText.text = "";
			active = false;
			timer = 0.0f;
		}
    }
	
	
	public void UpdateMessage(string message){
		active = true;
		MyText.text = message;
		
		
		
	}

}
