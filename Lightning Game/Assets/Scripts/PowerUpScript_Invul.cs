using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript_Invul : MonoBehaviour
{
     public bool activated = false;
	public float length = 10.0f;
	public float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activated){
			timer += Time.deltaTime;
		}
		if(timer >= length){
			GameObject.Find("Player").GetComponent<PlayerHealthScript>().invul = false;
			GameObject.Find("Player").GetComponent<Renderer>().material.color = Color.white;
			Destroy(gameObject);
		}
			
    }
	
	public void Activate(){
		activated = true;
		GameObject.Find("Player").GetComponent<PlayerHealthScript>().invul = true;
		GameObject.Find("Player").GetComponent<Renderer>().material.color = Color.yellow;
		
	}
}
