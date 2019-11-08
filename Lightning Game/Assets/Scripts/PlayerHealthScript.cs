using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public int hp = 1;
	public bool invul = false;


    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealthScript player = collision.gameObject.GetComponent<PlayerHealthScript>();
        EnemyMoveScript1 enemy1 = collision.gameObject.GetComponent<EnemyMoveScript1>();
        EnemyMoveScript2 enemy2 = collision.gameObject.GetComponent<EnemyMoveScript2>();
		EnemyMoveScript3 enemy3 = collision.gameObject.GetComponent<EnemyMoveScript3>();
		EnemyBlastMoveScript enemyFire =collision.gameObject.GetComponent<EnemyBlastMoveScript>();
		PowerUpScript_Health powHP = collision.gameObject.GetComponent<PowerUpScript_Health>();
		PowerUpScript_Fire powFire = collision.gameObject.GetComponent<PowerUpScript_Fire>();
		PowerUpScript_Triple powAmmo = collision.gameObject.GetComponent<PowerUpScript_Triple>();
		PowerUpScript_Invul powInvul = collision.gameObject.GetComponent<PowerUpScript_Invul>();
        BlastScript blast = collision.gameObject.GetComponent<BlastScript>();
		
		
		
        Debug.Log("Kaboom!!!");

        

        if ((enemy1 != null || enemy2 != null || enemy3 != null || enemyFire != null))
        {
			int dam = GameObject.Find("DifficultyController").GetComponent<DifficultyControllerScript>().damage;
			if(!invul)
				hp -= dam;
			 GameObject.Find("SoundFX").GetComponent<SoundFXHelperScript>().EnemyDeathSound();
			Destroy(collision.gameObject);
			GameObject.Find("Health").GetComponent<HealthDisplayScript>().HealthUpdate(hp);
            if (hp <= 0)
            {
				GameObject.Find("SoundFX").GetComponent<SoundFXHelperScript>().PlayerDeathSound();
                Destroy(gameObject);
            }
        }
		
		if(powHP != null){
			hp += 3;
			Destroy(collision.gameObject);
			GameObject.Find("SoundFX").GetComponent<SoundFXHelperScript>().RepairSound();
			GameObject.Find("Health").GetComponent<HealthDisplayScript>().HealthUpdate(hp);
		}
		
		if(powFire != null){
			GameObject.Find("SoundFX").GetComponent<SoundFXHelperScript>().PowerUpSound();
			collision.gameObject.GetComponent<PowerUpScript_Fire>().Activate();
			collision.gameObject.transform.position = new Vector3(100.0f, 100.0f, 0.0f);
		}
		
		if(powAmmo != null){
			GameObject.Find("SoundFX").GetComponent<SoundFXHelperScript>().PowerUpSound();
			collision.gameObject.GetComponent<PowerUpScript_Triple>().Activate();
			collision.gameObject.transform.position = new Vector3(100.0f, 100.0f, 0.0f);
		}
		
		if(powInvul != null){
			GameObject.Find("SoundFX").GetComponent<SoundFXHelperScript>().PowerUpSound();
			collision.gameObject.GetComponent<PowerUpScript_Invul>().Activate();
			collision.gameObject.transform.position = new Vector3(100.0f, 100.0f, 0.0f);
		}
		
		
    }

    private void OnDestroy()
    {
        var gameOver = FindObjectOfType<GameOverScript>();
        gameOver.ShowButtons();
    }
}
