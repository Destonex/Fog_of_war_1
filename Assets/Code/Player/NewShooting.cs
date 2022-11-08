using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewShooting : MonoBehaviour
{
    public Animation sniper;

    public float damage = 21f;
    public float fireRate = 1f;
    public float force = 155f;
    public float range = 15f;
    public ParticleSystem muzzleFlash;
    public Transform bulletSpawn;
    public AudioClip shotSFX;
    public AudioSource _audioSource;
    public GameObject[] hitEffect = new GameObject[5];
    
    public GameObject _cam;
        //public Camera _cam;
    private float nextFire = 0f;
    private int colAmmo = 5;
    public Text Ammo;
    private int n;
    private GameObject impact;

    private RegistrationHits registrationHits;
    public int t1 = 0;
    public int t2 = 0;
    public int t3 = 0;

 void Update()
    {
        Ammo.text = colAmmo.ToString();
        Anim();
        if(Input.GetButtonDown("Fire1") && Time.time > nextFire && !sniper.IsPlaying("Fire") && colAmmo !=0 && !sniper.IsPlaying("StartReload") && !sniper.IsPlaying("EndReload") && !sniper.IsPlaying("ContinuationReload"))
        {
            nextFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

void Anim(){
    if(!sniper.IsPlaying("Fire") && !sniper.IsPlaying("StartReload") && !sniper.IsPlaying("EndReload") && !sniper.IsPlaying("ContinuationReload")){
            sniper.Play("Idle");
        if(colAmmo < 5){
            if(Input.GetKeyDown("r")){
                n=0;
                    /*     if(colAmmo < 5){
                        sniper.GetComponent<Animation>().Stop();
                        sniper.GetComponent<Animation>().Play("Reload1");
                        colAmmo++;
                        }
                        }
                        else if(Input.GetKeyDown("r") && colAmmo == 0)
                    {*/
                /*sniper.GetComponent<Animation>().Stop();
                for (int i = 0; i < 4 - colAmmo; i++){
                    if(4 - colAmmo != colAmmo-1)
                        sniper.GetComponent<Animation>().PlayQueued("Reload2");
                    n++;
                    
                    }
                    sniper.GetComponent<Animation>().PlayQueued("Reload1");
                    n++;*/
                    sniper.Stop();
                    sniper.Play("StartReload");

                    for (int i = 0; i < 4 - colAmmo; i++){
                        if(4 - colAmmo != colAmmo-1)
                            sniper.PlayQueued("ContinuationReload");
                        n++;
                    }
                    sniper.PlayQueued("EndReload");
                    n++;

                    colAmmo = colAmmo + n; 
            }
                    
        }
    }
}

    void Shoot()
    {
        colAmmo--;
         if(Input.GetButtonDown("Fire1"))
            {
                sniper.Stop();
                sniper.Play("Fire");
            }

        _audioSource.PlayOneShot(shotSFX);

        muzzleFlash.Play();
        RaycastHit hit;

        if(Physics.Raycast(_cam.transform.position, _cam.transform.forward, out hit, range))
        {
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
                else if (hit.transform.gameObject.tag == "Target1"){
                    t1++;
                    impact = Instantiate(hitEffect[0], hit.point, Quaternion.LookRotation(hit.normal));
                }
                else if(hit.transform.gameObject.tag == "Target2"){
                    t2++;
                    impact = Instantiate(hitEffect[0], hit.point, Quaternion.LookRotation(hit.normal));
                }
                else if(hit.transform.gameObject.tag == "Target3"){
                    t3++;
                    impact = Instantiate(hitEffect[1], hit.point, Quaternion.LookRotation(hit.normal));
                }
                else
                    impact = Instantiate(hitEffect[1], hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 2f);

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }
        
            
            
        }
    }

}
