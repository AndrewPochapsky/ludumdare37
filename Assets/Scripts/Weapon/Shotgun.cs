using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : BaseWeapon {
    int amountOfBullets=5;
    float initialVelocityOffSet= 0.75f;
	// Use this for initialization
	void Start () {
        Cam = GameObject.FindObjectOfType<Camera>();
        spriteRotation = SpriteRotation.Right;
        GunExit = transform.GetChild(0).transform;
        FireRate = 1.15f;
        BulletSpeed = 20;
        Damage = 1.5f;
        BulletScaleX = 0.25f;
        BulletScaleY = 0.25f;
    }

    public override void Fire()
    {
        //base.Fire();
        if(Time.time > NextFire)
        {
            for (int i = 0; i < amountOfBullets; i++)
            {
                print("happening"); 
                float velocityOffSet = initialVelocityOffSet * i;
                print("i: " + i);
                print("velocity offset: " + velocityOffSet);
                GameObject bullet = Instantiate(Resources.Load<GameObject>("Weapons/Bullet"), GunExit.position, GunExit.rotation);
                bullet.transform.localScale = new Vector2(BulletScaleX, BulletScaleY);
                bullet.GetComponent<Rigidbody2D>().velocity = (Direction * (BulletSpeed-velocityOffSet));
            }
            
            NextFire = Time.time + FireRate;
        }
    }


}
