using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOpen : MonoBehaviour
{
    public GameObject Map;
    private bool active = false;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        Map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown("m") && active == false && Cube.activeSelf == false)  {
      Map.SetActive(true);
      active = true;
    }
    else if (Input.GetKeyDown("m") && active == true){
      Map.SetActive(false);
      active= false;
    }
    }
}
