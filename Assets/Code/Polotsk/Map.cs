using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject qustion;
    public GameObject krug;

    public MapOpen Maptr;

    public void Start()
    {
        qustion.SetActive(true);
        krug.SetActive(false);
    }

    public void OnTriggerEnter(Collider col)
    {
        if(Maptr.Cube.activeSelf == false)
        {
            qustion.SetActive(false);
            krug.SetActive(true); 
        }
        
    }
}
