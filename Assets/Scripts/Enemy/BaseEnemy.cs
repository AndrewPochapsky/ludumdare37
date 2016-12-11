using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour{

    public float Speed { get; set; }
    public float Damage { get; set; }
    public float Health { get; set; }

    public GameObject Gun { get; set; }
    public ChangeDirection changeDirection;
    public enum Direction { RIGHT, LEFT }
    public Direction direction { get; set; }

  

    public virtual void Update()
    {
        
        if (changeDirection.i == 0)
        {
            direction = Direction.RIGHT;
        }
        else if (changeDirection.i == 1)
        {
            direction = Direction.LEFT;
        }
        if(Health <= 0)
        {
            Die();
        }
    }

    public virtual void Move(Direction _direction)
    {
        if (_direction == Direction.RIGHT)
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }
        else if (_direction == Direction.LEFT)
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
    }

    public virtual void OnCollisionEnter2D(Collision2D col)
    {
        Bullet bullet = col.gameObject.GetComponent<Bullet>();
        if (bullet)
        {
            Health -= bullet.damage;
            print("Currenthealth: " + Health);
            Destroy(col.gameObject);
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
   
}
