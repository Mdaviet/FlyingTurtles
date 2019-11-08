using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript_Triple : MonoBehaviour
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
			GameObject[] weapons = GameObject.FindGameObjectsWithTag("WeaponExtra");
			for(int i = 0; i < weapons.Length; i++){
				weapons[i].GetComponent<WeaponScript>().active = false;
				
			}
			Destroy(gameObject);
		}
			
    }
	
	public void Activate(){
		activated = true;
		GameObject[] weapons = GameObject.FindGameObjectsWithTag("WeaponExtra");
		for(int i = 0; i < weapons.Length; i++){
			weapons[i].GetComponent<WeaponScript>().active = true;
			
		}
		
	}
}
