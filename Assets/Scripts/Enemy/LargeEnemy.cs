using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeEnemy : BaseEnemy {

	// Use this for initialization
	void Start () {
        direction = (Direction)Random.Range(0, 2);
        Speed = 2.5f;
        Health = 10;
        changeDirection = transform.GetChild(0).GetComponent<ChangeDirection>();
    }
	
	// Update is called once per frame
	public override void Update () {
        base.Update();
        base.Move(direction);
	}
}
