using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionObject : MonoBehaviour
{
    public GameObject Dom;
    public GameObject t_Dom;
    public GameObject Cube;
    public GameObject t_Cube;

    public void f_Dom(){
        Dom.SetActive(true);
        t_Dom.SetActive(true);
        Cube.SetActive(false);
        t_Cube.SetActive(false);
    }

    public void f_Cube(){
        Dom.SetActive(false);
        t_Dom.SetActive(false);
        Cube.SetActive(true);
        t_Cube.SetActive(true);
    }

   /* void Start()
    {
        
    }

    void Update()
    {
        
    }*/
}
