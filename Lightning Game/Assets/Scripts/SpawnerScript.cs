using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
	public Transform EnemyPrefab;
	public float width;
	public float height;
	private Vector2 topLeftCorner;
	private Vector2 topRightCorner;
	private Vector2 bottomLeftCorner;
	private Vector2 bottomRightCorner;
	public float spawnRate;
	private float timer = 0.0f;
	public float timerOffset = 0.0f;
	
    // Start is called before the first frame update
    void Start()
    {
		
		timer = timerOffset;
		topLeftCorner = new Vector2(  transform.position.x - width/2  ,  transform.position.y + height/2  );
		topRightCorner = new Vector2(  transform.position.x + width/2  ,  transform.position.y + height/2  );
		bottomLeftCorner = new Vector2(  transform.position.x - width/2  ,  transform.position.y - height/2  );
		bottomRightCorner = new Vector2(  transform.position.x + width/2  ,  transform.position.y - height/2  );
		
        
    }

    // Update is called once per frame
    void Update()
    {
		/*if(timer >= spawnRate){
			SpawnRand();
			timer = 0.0f;
		}
		timer = timer + Time.deltaTime;
        */
    }
	
	public void SpawnRand(){
		var enemyTransform = Instantiate(EnemyPrefab) as Transform;
		Vector2 randPos = new Vector2(Random.Range(topLeftCorner.x, topRightCorner.x),Random.Range(topLeftCorner.y, bottomLeftCorner.y));
		enemyTransform.position = randPos;
	}
	
}
