using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseScript : MonoBehaviour
{
    public GameObject SmallCanvas;
    private bool _indicator;
    public GameObject Mosin;

    public void Update()
    {
        if (_indicator==true)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

    }
    
 
    public void Pause()
    {
        SmallCanvas.SetActive(true);
        Mosin.SetActive(false);
        _indicator = true;
    }

    public void Resume()
    {
        SmallCanvas.SetActive(false);
        Mosin.SetActive(true);
        _indicator = false;
    }
}
