using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
	
	
	public int hp = 1;
	public bool isEnemy;
	

    // Update is called once per frame
   void OnTriggerEnter2D(Collider2D collider){
	   
	   BlastScript blast = collider.gameObject.GetComponent<BlastScript>();
	   EnemyBlastScript blast2 = collider.gameObject.GetComponent<EnemyBlastScript>();
	   Debug.Log("I'm hit!");
	   
	   if(blast != null && isEnemy){
		   
		   hp-= blast.damage;
		   Destroy(blast.gameObject);
		   
		   if(hp <= 0){
			   Destroy(gameObject);
		   }
	   }
	   
	   if(blast2 != null && !isEnemy){
		   
		   hp-= blast.damage;
		   Destroy(blast.gameObject);
		   
		   if(hp <= 0){
			   Destroy(gameObject);
		   }
	   }
	   
	   
	   
	   
   }
}
