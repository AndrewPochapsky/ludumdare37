using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : BaseWeapon {

	// Use this for initialization
	void Start () {
        Cam = GameObject.FindObjectOfType<Camera>();
        spriteRotation = SpriteRotation.Left;
        GunExit = transform.GetChild(0).transform;
        FireRate = 1;
        BulletSpeed = 20;
        Damage = 2;

	}
	
	

}
