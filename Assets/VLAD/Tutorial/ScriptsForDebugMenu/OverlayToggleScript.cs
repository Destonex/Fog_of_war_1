using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverlayToggleScript : MonoBehaviour
{
    public GameObject EmptyOverlayToggle;

    //public Canvas OverlayToggle;
    public GameObject OverlayToggle;

    // Start is called before the first frame update
    void Start()
    {
        //OverlayToggle = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void OverlayToggleButtonClick()
   {
        if(EmptyOverlayToggle.activeInHierarchy){
            EmptyOverlayToggle.SetActive(false);
            OverlayToggle.SetActive(false);
        }
        else
        {
            EmptyOverlayToggle.SetActive(true);
            OverlayToggle.SetActive(true);
        }
   }
}
