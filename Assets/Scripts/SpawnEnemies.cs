using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
    private float spawnRate=5;
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
            Spawn();
            nextSpawn = spawnRate + Time.time;
        }
	}

    void Spawn()
    {
       
        for (int i = 0; i < enemyNum; i++)
        {
            Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject enemy = Instantiate(Resources.Load<GameObject>("Enemies/Enemy" + Random.Range(0, 3)), _sp.position, _sp.rotation);
        }
        

    }

}
