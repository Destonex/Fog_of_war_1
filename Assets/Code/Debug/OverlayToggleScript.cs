using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverlayToggleScript : MonoBehaviour
{
    public GameObject EmptyOverlayToggle;
    public GameObject OverlayToggle;

    public void OverlayToggleButtonClick()
    {
        if(EmptyOverlayToggle.activeInHierarchy)
        {
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
