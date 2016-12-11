using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : MonoBehaviour {

    public float FireRate { get; set; }
    public float Damage { get; set; }
    public float NextFire { get; set; }
    public string Name { get; set; }
    public float BulletSpeed { get; set; }
    public float BulletScaleX { get; set; }
    public float BulletScaleY { get; set; }

    public Vector2 MousePosition { get; set; }
    public Camera Cam;
    public Vector2 Direction;

    public Transform GunExit;
    public enum SpriteRotation
    {
        Up = -90,
        Down = 90,
        Right = 0,
        Left = 180
    }
    public SpriteRotation spriteRotation;
    public float Angle;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public virtual void Update () {
        RotateWeapon();
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
	}

    public virtual void Fire()
    {
         if(Time.time > NextFire)
        {
           
            GameObject bullet = Instantiate(Resources.Load<GameObject>("Weapons/Bullet"), GunExit.position, GunExit.rotation);
            bullet.transform.localScale = new Vector2(BulletScaleX, BulletScaleY);
            bullet.GetComponent<Rigidbody2D>().velocity = (Direction * BulletSpeed);
            NextFire = Time.time + FireRate;
        }
    }

    public virtual void RotateWeapon()
    {
        MousePosition = Cam.ScreenToWorldPoint(Input.mousePosition);
        Direction = (MousePosition - (Vector2)transform.position).normalized;
        Angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg + (int)spriteRotation;
        transform.rotation = Quaternion.AngleAxis(Angle, Vector3.forward);
    }


}
