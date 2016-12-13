using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : BaseWeapon {

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        Cam = GameObject.FindObjectOfType<Camera>();
        spriteRotation = SpriteRotation.Left;
        GunExit = transform.GetChild(0).transform;
        FireRate = 0.7f;
        BulletSpeed = 20;
        Damage = 3;
        BulletScaleX = 0.25f;
        BulletScaleY = 0.25f;

    }
	
	

}
