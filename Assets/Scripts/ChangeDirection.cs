using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour {
    [HideInInspector]
    public int i= -1;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "RightWall")
        {
            i = 1;
        }
        else if (col.tag == "LeftWall")
        {
            i = 0;
        }
    }

}
