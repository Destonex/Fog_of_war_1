using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewShooting : MonoBehaviour
{
    private Animation sniper;

    public float damage = 70f;
    public float fireRate = 1f;
    public float force = 155f;
    public float range = 15f;
    public ParticleSystem muzzleFlash;
    public AudioClip shotSFX;
    public GameObject[] hitEffect = new GameObject[5];
    public Text Ammo;
    
    private AudioSource _audioSource;
    private float nextFire = 0f;
    private int colAmmo = 5;
    private int n;
    private GameObject impact;
    private Transform _cam;
    private RegistrationHits registrationHits;
    internal int t1 = 0;
    internal int t2 = 0;
    internal int t3 = 0;

    void Start()
    {
        gameObject.GetComponent<AudioSource>().clip = shotSFX;
        _audioSource = gameObject.GetComponent<AudioSource>();
        _cam = transform.parent.GetComponent<Transform>();
        sniper = gameObject.GetComponent<Animation>(); 
    }

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

    void Anim()
    {
        if(!sniper.IsPlaying("Fire") && !sniper.IsPlaying("StartReload") && !sniper.IsPlaying("EndReload") && !sniper.IsPlaying("ContinuationReload")){
            sniper.Play("Idle");
            if(colAmmo < 5)
            {
                if(Input.GetKeyDown("r"))
                {
                    n=0;
                    sniper.Stop();
                    sniper.Play("StartReload");
                    for (int i = 0; i < 4 - colAmmo; i++)
                    {
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
