using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHelperScript : MonoBehaviour
{
	
	private int spawnerCount;
	private GameObject[] children;
	public float spawnRate = 1.0f;
	public float timer = 0.0f;
	public float timerOffset = 0.0f;
	
    // Start is called before the first frame update
    void Start()
    {
		spawnerCount = transform.childCount;
		children = GameObject.FindGameObjectsWithTag("Spawner");
        
    }

    // Update is called once per frame
    void Update()
    {
		int spawnSelect = Random.Range(0, spawnerCount-1);
		if(timer >= spawnRate){
			children[spawnSelect].GetComponent<SpawnerScript>().SpawnRand();
			timer = 0.0f;
		}
		timer = timer + Time.deltaTime;
        
		
        
    }
}
