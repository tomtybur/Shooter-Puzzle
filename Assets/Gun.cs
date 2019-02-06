using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform Ammo;
    public float fireDelay = 0.25f;
    private float counter;
    private bool canShoot = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
       if (Input.GetAxis("Fire1") > 0 && canShoot) 
       {
            //Instantiate returns the object that gets created
            Transform Bullet = Instantiate(Ammo, transform.position, Quaternion.identity);
            Bullet.forward = this.transform.forward;
            canShoot = false;
            counter = 0f;
       }
       if (counter >= fireDelay) 
       {
            canShoot = true;
       }
    }
}
