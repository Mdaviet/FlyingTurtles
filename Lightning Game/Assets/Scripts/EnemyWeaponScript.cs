using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponScript : MonoBehaviour
{
	  public Transform BlastPrefab;
	  public float shotInterval;
	  float cooldown = 0.0f;

    // Update is called once per frame
	
	void Start(){
		shotInterval = GameObject.Find("DifficultyController").GetComponent<DifficultyControllerScript>().fireRate;
	}
	
    void Update()
    {
		
		KeyBoardHelperScript kbh = GameObject.Find("KeyBoardHelper").GetComponent<KeyBoardHelperScript>();
		EnemyMoveScript2 parent = gameObject.GetComponent<EnemyMoveScript2>();
		
		if(cooldown == shotInterval && parent.inPlace){
			Fire();
			GameObject.Find("SoundFX").GetComponent<SoundFXHelperScript>().EnemyShotSound();
			
			cooldown = 0.0f;
			
		}
		else{
			if(cooldown >= shotInterval)
				cooldown = shotInterval;
			else
				cooldown = cooldown + Time.deltaTime;
		}
		
        
    }
	
	
	public void Fire()
  {
    

      // Create a new shot
      var blastTransform = Instantiate(BlastPrefab) as Transform;

      // Assign position
      blastTransform.position = transform.position;
	  blastTransform.eulerAngles = transform.eulerAngles;
  
    
  }

	
}
