using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    BaseWeapon currentWeapon;
    [HideInInspector]
    public float damage;
	// Use this for initialization
	void Start () {
        currentWeapon = FindObjectOfType<BaseWeapon>();
        damage = currentWeapon.Damage;
	}
	
	// Update is called once per frame
	void Update () {
        print("Current damage: " + damage);
	}
}
