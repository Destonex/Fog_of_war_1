using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityTemplateProjects;

public class NoClipScript : MonoBehaviour
{
    public GameObject EmptyNoclip;

    public FirstPersonController firstPersonController;
    public SimpleCameraController simpleCameraController;
   
    public void Start()
    {
        firstPersonController = gameObject.GetComponent<FirstPersonController>();
        simpleCameraController = gameObject.GetComponentInChildren<SimpleCameraController>();

        firstPersonController.enabled = true;
        simpleCameraController.enabled = false;
    }
 
    public void Update() 
    {
        if(EmptyNoclip.activeSelf)
        {
            firstPersonController.enabled = true;
            simpleCameraController.enabled = false;
        }
        else if (!EmptyNoclip.activeSelf)
        {
            firstPersonController.enabled = false;
            simpleCameraController.enabled = true;
        }

    }

    public void NoclipButtonClick()
    {
        if(EmptyNoclip.activeSelf == true)
        {
            EmptyNoclip.SetActive(false);
        }
        else
        {
            EmptyNoclip.SetActive(true);
        }

    }
   
}
