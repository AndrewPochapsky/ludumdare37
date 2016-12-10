using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFloor : MonoBehaviour {
    public static bool canJump = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print("canJump=" + canJump);
	}

    bool OnTriggerEnter2D(Collider2D col)
    {
        print("tag is "+ col.tag);
        
        if (col.tag == "Floor")
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }
        return canJump;

    }

}
