using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : BaseEnemy {

    
    void Start()
    {
        direction = (Direction)(Random.Range(0, 2));
        Speed = 5;
        changeDirection=transform.GetChild(0).GetComponent<ChangeDirection>();
        Health = 6;
    }

    
   public override void Update () {
        base.Update();
        base.Move(direction);
    }

    

}
