using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;




public class PauseScript : MonoBehaviour
{
   public GameObject SmallCanvas;
    bool _indicator;
    public GameObject Mosin;
    //public FirstPersonController firstPersonController;
    //public MouseLook mouseLook;


    void Start()
    {
        //firstPersonController = GetComponent<FirstPersonController>();
        //mouseLook = GetComponent<MouseLook>();


    }

    void Update()
    {
        if (_indicator==true)
        {
            Time.timeScale = 0;
            
        }
        else
            Time.timeScale = 1;
    }
    
 
    public void Pause()
    {
        SmallCanvas.SetActive(true);
        Mosin.SetActive(false);
        _indicator = true;
        //firstPersonController.enabled = false;
        
        //mouseLook.XSensitivity = 0f;
        //mouseLook.YSensitivity = 0f;


    }

    public void Resume()
    {
        SmallCanvas.SetActive(false);
        Mosin.SetActive(true);
        _indicator = false;
        //firstPersonController.enabled = true;

        //mouseLook.XSensitivity = 2f;
        //mouseLook.YSensitivity = 2f;


    }
}
