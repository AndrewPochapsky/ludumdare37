using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : BaseWeapon {

	// Use this for initialization
	void Start () {
        Cam = GameObject.FindObjectOfType<Camera>();
        spriteRotation = SpriteRotation.Right;
        GunExit = transform.GetChild(0).transform;
        FireRate = 0.2f;
        BulletSpeed = 20;
        Damage = 2;
        BulletScaleX = 0.25f;
        BulletScaleY = 0.25f;
        audioSource = GetComponent<AudioSource>();
    }
	
}
