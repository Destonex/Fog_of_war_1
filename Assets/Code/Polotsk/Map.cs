using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject qustion;
    public GameObject krug;
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
       qustion.SetActive(false);
        krug.SetActive(true); 
    }

}
