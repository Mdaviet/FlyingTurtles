using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
		EnemyMoveScript2 enemy = collider.gameObject.GetComponent<EnemyMoveScript2>();
		if (enemy != null){
			
			enemy.inPlace = true;
			
		}
		
		
		
	}
}
