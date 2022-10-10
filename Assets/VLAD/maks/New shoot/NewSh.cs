using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSh : MonoBehaviour
{
    public float damage = 21f;
    public float fireRate = 1f;
    public float range = 15f;
    public float force = 155f;
    public GameObject muzzleFlash;
    public GameObject[] hitEffect = new GameObject[5];
    //public GameObject hitEffect;
    public Camera _cam;
    private float nextFire = 0f;

    private GameObject impact;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(_cam.transform.position, _cam.transform.forward, out hit, range))
        {
            //GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));

            //GameObject impact = Instantiate(hitEffect[1], hit.point, Quaternion.LookRotation(hit.normal));
            
                if(hit.transform.gameObject.tag == "Wood")
                    impact = Instantiate(hitEffect[0], hit.point, Quaternion.LookRotation(hit.normal));
                else if(hit.transform.gameObject.tag == "Stone")
                    impact = Instantiate(hitEffect[1], hit.point, Quaternion.LookRotation(hit.normal));
                else if(hit.transform.gameObject.tag == "Metal")
                    impact = Instantiate(hitEffect[2], hit.point, Quaternion.LookRotation(hit.normal));
                else if(hit.transform.gameObject.tag == "Sand")
                    impact = Instantiate(hitEffect[3], hit.point, Quaternion.LookRotation(hit.normal));
                else if(hit.transform.gameObject.tag == "AI")
                    impact = Instantiate(hitEffect[4], hit.point, Quaternion.LookRotation(hit.normal));

            Destroy(impact, 2f);

            if(hit.rigidbody != null)
                hit.rigidbody.AddForce(-hit.normal * force);
        }

    }
}
