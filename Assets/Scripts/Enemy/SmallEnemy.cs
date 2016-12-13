using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : BaseEnemy {

    
    public override void Start()
    {
        direction = (Direction)(Random.Range(0, 2));
        Speed = 5;
        changeDirection=transform.GetChild(0).GetComponent<ChangeDirection>();
        Health = 5;
        ColorToChangeTo = new Color(214, 190, 190);
        spriteRenderer = GetComponent<SpriteRenderer>();
        base.Start();
    }

    
   public override void Update () {
        base.Update();
        base.Move(direction);
    }

    

}
