using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public ItemManager im;
    public Transform Gun;
    Vector2 direction;
    public GameObject bullet;
    public float BulletSpeed;
    public Transform ShootPoint;
    public float fireRate;
    float ReadyForNextShot;
    //public GameObject weaponToGive;


    public Animator animator;

    void Update()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)Gun.position;
        FaceMouse();
        
        if(Input.GetMouseButtonDown(1) && im.flyCount > 0)
        {
            im.flyCount--;
            //animator.SetTrigger("IsShooting");
            if(Time.time > ReadyForNextShot)
            {
                ReadyForNextShot = Time.time + 1/fireRate;
                shoot();
            }
            
        }
            
        
       
    }

    void FaceMouse()
    {
        Gun.transform.right = direction;
    }

    void shoot()
    {
        GameObject BulletIns = Instantiate(bullet, ShootPoint.position, ShootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
        Destroy(BulletIns, 3);
    }


}