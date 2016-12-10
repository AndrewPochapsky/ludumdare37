using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int speed = 5;
    public int jumpStrength=10;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Move();
        
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (DetectFloor.canJump && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpStrength);
            DetectFloor.canJump = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector2.down * speed * Time.deltaTime);
        //}
    }




}
