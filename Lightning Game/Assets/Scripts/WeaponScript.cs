using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
	  public Transform BlastPrefab;
	  public float shotInterval = 1.0f;
	  float cooldown = 0.0f;
	  public bool active = true;

    // Update is called once per frame
    void Update()
    {
		if(active){
			KeyBoardHelperScript kbh = GameObject.Find("KeyBoardHelper").GetComponent<KeyBoardHelperScript>();
			
			if(cooldown == shotInterval && kbh.spaceKeyHeld){
				Fire();
				GameObject.Find("SoundFX").GetComponent<SoundFXHelperScript>().PlayerShotSound();
				
				cooldown = 0.0f;
				
			}
			else{
				if(cooldown >= shotInterval)
					cooldown = shotInterval;
				else
					cooldown = cooldown + Time.deltaTime;
			}
			
        }
    }
	
	
	public void Fire()
  {
    

      // Create a new shot
      var blastTransform = Instantiate(BlastPrefab) as Transform;

      // Assign position
      blastTransform.position = transform.position;

  
    
  }

	
}
