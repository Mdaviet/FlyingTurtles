using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyControllerScript : MonoBehaviour
{
	
	public float spawnRate;
	public int damage;
	public float speed;
	public float fireRate;
	public int score;
	
	public int enemiesKilled;
	public int level;
	
	
	
	
	
	
    // Start is called before the first frame update
    void Start()
    {
		spawnRate = 4.0f;
		damage = 1;
		speed = 5.0f;
		fireRate = 2.5f;
		level = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
		
		
		
        
    }
	
	public void onKill(){
		if(enemiesKilled != 0 && enemiesKilled % (level*5) == 0){
			enemiesKilled = 0;
			level++;
			GameObject.Find("Level").GetComponent<LevelTextScript>().LevelUpdate(level);
			GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
			for(int i = 0; i < enemies.Length; i++){
				Destroy(enemies[i]);
			}

			{
			//spawn rate  a /(b + e^(x/c)) + d
			// This equation represents an inverse e^x curve, perfect for ramping down the spawn interval
			// c controls how fast the drop happens
			// d controls the minimum value
			// a and b control the shape of the graph, don't touch
			float a = 5.2f;
			float b = 0.6f;
			float c = 3.6f;
			float d = 0.75f;
			
			float e = 2.7182818284f; //approximatly
			
			spawnRate = a /(b + Mathf.Pow(e, (level/c))) + d;
			}
			
			
			//Damage
			//Increases ever 3 levels
			
			if(level % 3 == 0){
				damage++;
				
			}
			
			//Speed
			//Increase by 1.0 every level, until it gets to 20
			
			if(speed < 20.0f){
				speed += 1.0f;
			}
			
			{
			//Fire Rate  a /(b + e^(x/c)) + d
			// This equation represents an inverse e^x curve, perfect for ramping down the spawn interval
			// c controls how fast the drop happens
			// d controls the minimum value
			// a and b control the shape of the graph, don't touch
			float a = 5.2f;
			float b = 0.6f;
			float c = 3.6f;
			float d = 0.75f;
			
			float e = 2.7182818284f; //approximatly
			
			fireRate = a /(b + Mathf.Pow(e, (level/c))) + d;
			}
			
			
			
		}
		
		score += level*10;
		GameObject.Find("Score").GetComponent<ScoreScript>().ScoreUpdate(score);
			
	}
}
