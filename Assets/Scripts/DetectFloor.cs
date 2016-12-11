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

    bool OnTriggerStay2D(Collider2D col)
    {
        
        
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
