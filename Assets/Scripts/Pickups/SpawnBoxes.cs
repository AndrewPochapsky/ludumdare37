using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxes : MonoBehaviour {
    Transform[] spawnPoints;
    Box box;
    Transform lastSpawnTransform;
    int spawnIndex;
    int lastSpawnIndex;
    int timesSpawned;
    Transform sp;
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
        //if there is not a box in scene already
        if(!(box = GameObject.FindObjectOfType<Box>()))
        {
            Spawn();
        }
        //print("SpawnIndex: " + spawnIndex);
        //print("LastSpawnIndex: " + lastSpawnIndex);
        
	}

    void Spawn()
    {
        spawnIndex = Random.Range(0, spawnPoints.Length);
        //loops prevents the box spawning at the same place twice in a row
        while (spawnIndex == lastSpawnIndex)
        {
            spawnIndex = Random.Range(0, spawnPoints.Length);
        }

        sp = spawnPoints[spawnIndex];
        Instantiate(Resources.Load<GameObject>("Pickups/Box"), sp.position, sp.rotation);
        lastSpawnIndex = spawnIndex;




    }

}
