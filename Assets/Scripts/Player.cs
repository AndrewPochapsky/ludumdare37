using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    private Rigidbody2D rb;
    private CharacterStats stats;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        stats = GetComponent<CharacterStats>();
    }

	// Use this for initialization
	void Start () {
       
        stats.Speed = 10;
        stats.JumpStrength = 750;
	}
	
	// Update is called once per frame
	void Update () {

        Move();
       
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            
            if (transform.position.x > -15.13295f)
            {
                transform.Translate(Vector2.left * stats.Speed * Time.deltaTime);
            }
            
        }

        if (DetectFloor.canJump && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * stats.JumpStrength);
            
            DetectFloor.canJump = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //fixes bug where player would go into wall briefly, didnt use rb.MovePosition() cause it made the player float in air when moving
            
            if (transform.position.x < 15.07445f)
            {
                transform.Translate(Vector2.right * stats.Speed * Time.deltaTime);
            }
          
           
        }
    }




}
