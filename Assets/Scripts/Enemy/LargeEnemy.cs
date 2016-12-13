using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeEnemy : BaseEnemy {

	// Use this for initialization
	public override void Start () {
        direction = (Direction)Random.Range(0, 2);
        Speed = 2.5f;
        Health = 10;
        changeDirection = transform.GetChild(0).GetComponent<ChangeDirection>();      
        ColorToChangeTo = new Color(214, 190, 190);
        spriteRenderer = GetComponent<SpriteRenderer>();
        base.Start();
    }
	
	// Update is called once per frame
	public override void Update () {
        base.Update();
        base.Move(direction);
	}
}
