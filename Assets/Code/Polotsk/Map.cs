using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject qustion;
    public GameObject krug;
    public MapOpen Maptr;
    // Start is called before the first frame update
    void Start()
    {
        qustion.SetActive(true);
        krug.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(Maptr.Cube.activeSelf == false){
            qustion.SetActive(false);
            krug.SetActive(true); 
        }
    }
}
