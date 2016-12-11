using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    int newWeapon;
    Player player;
    Transform playerHand;
    GameObject currentWeapon;
	// Use this for initialization
	void Start () {
        player = GameObject.FindObjectOfType<Player>();
        playerHand = player.transform.GetChild(0).transform;
        currentWeapon = playerHand.transform.GetChild(0).gameObject;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Player player = col.gameObject.GetComponent<Player>();
        if (player)
        {
            SwitchWeapon();
            
            print("CurrentScore: " + ScoreManager.score);
            Destroy(gameObject);
        }
    }

    void SwitchWeapon()
    {
        newWeapon = Random.Range(0, 4);
        if(currentWeapon != null)
        {
            Destroy(currentWeapon);
        }
        GameObject weapon = Instantiate(Resources.Load<GameObject>("Weapons/gun" + newWeapon), playerHand.position, playerHand.rotation);
        weapon.transform.SetParent(playerHand);
        ScoreManager.score++;

    }

}
