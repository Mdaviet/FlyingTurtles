using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXHelperScript : MonoBehaviour
{
	
	
	
	public static SoundFXHelperScript Instance;

	public AudioClip playerDeath;
	public AudioClip playerShot;
	public AudioClip enemyDeath;
	public AudioClip enemyShot;
	public AudioClip repair;
	public AudioClip powerUp;
    // Start is called before the first frame update
    void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
		  Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}
	
	public void PlayerDeathSound(){
		MakeSound(playerDeath);
	}
	public void PlayerShotSound(){
		MakeSound(playerShot);
	}
	public void EnemyDeathSound(){
		MakeSound(enemyDeath);
	}
	public void EnemyShotSound(){
		MakeSound(enemyShot);
	}
	public void RepairSound(){
		MakeSound(repair);
	}
	public void PowerUpSound(){
		MakeSound(powerUp);
	}
	
	
	private void MakeSound(AudioClip originalClip)
	  {
		
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	  }
}
