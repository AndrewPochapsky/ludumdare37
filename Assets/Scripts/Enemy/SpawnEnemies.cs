using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
    private float batchSpawnRate=8;
    private float waveSpawnRate = 2;
    private int enemyNum = 3;
    private float nextSpawn;
    private Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
        spawnPoints = new Transform[transform.childCount];
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnPoints[i] = transform.GetChild(i);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn)
        {
            StartCoroutine(Spawn());
            nextSpawn = batchSpawnRate + Time.time;
        }
        print("BatchSpawnRate: " + batchSpawnRate);
        IncreaseSpawn();
	}

    IEnumerator Spawn()
    {
       
        for (int i = 0; i < enemyNum; i++)
        {
            Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject enemy = Instantiate(Resources.Load<GameObject>("Enemies/Enemy"+ Random.Range(0,2)) , _sp.position, _sp.rotation);
            yield return new WaitForSeconds(1f / waveSpawnRate);
        }
    }

    public void IncreaseSpawn()
    {
        if(TimeManager.time >= 60)
        {
            batchSpawnRate = 6;
        }
        else if(TimeManager.time >= 120)
        {
            enemyNum = 5;
        }
        
    }


}
