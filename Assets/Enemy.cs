using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private enum Direction { RIGHT, LEFT}
    private int speed = 5;
    Direction direction;

    private ChangeDirection changeDirection;
    //private WallDetector wallDetector;
	// Use this for initialization
	void Start () {

        direction = (Direction)Random.Range(0,2);
        changeDirection = transform.GetChild(0).GetComponent<ChangeDirection>();
	}
	
	// Update is called once per frame
	void Update () {
        if (changeDirection.i == 0)
        {
            direction = Direction.RIGHT;
        }
        else if (changeDirection.i == 1)
        {
            direction = Direction.LEFT;
        }
        Move();
	}

    void Move()
    {
        if (direction == Direction.LEFT)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if(direction == Direction.RIGHT)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

}
