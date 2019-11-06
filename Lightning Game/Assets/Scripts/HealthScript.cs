using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
	
	
	public int hp = 1;
	

    // Update is called once per frame
   void OnTriggerEnter2D(Collider2D collider){
	   
	   BlastScript blast = collider.gameObject.GetComponent<BlastScript>();
	   Debug.Log("I'm hit!");
	   
	   if(blast != null){
		   
		   hp-= blast.damage;
		   Destroy(blast.gameObject);
		   
		   if(hp <= 0){
			   Destroy(gameObject);
		   }
	   }
	   
	   
	   
   }
}
