using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOpen : MonoBehaviour
{
  public GameObject Map;
  public GameObject Cube;
  
  private bool active = false;
    
  public void Start()
  {
    Map.SetActive(false);
  }

  public void Update()
  {
    if (Input.GetKeyDown("m") && active == false && Cube.activeSelf == false)  
    {
      Map.SetActive(true);
      active = true;
    }
    else if (Input.GetKeyDown("m") && active == true)
    {
      Map.SetActive(false);
      active= false;
    }
    
  }
}
