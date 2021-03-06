﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : BaseWeapon {

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        Cam = GameObject.FindObjectOfType<Camera>();
        spriteRotation = SpriteRotation.Right;
        GunExit = transform.GetChild(0).transform;
        FireRate = 1.15f;
        BulletSpeed = 20;
        Damage = 5;
        BulletScaleX = 0.35f;
        BulletScaleY = 0.35f;
    }
	
	
}
