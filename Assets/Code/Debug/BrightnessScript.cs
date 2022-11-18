using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessScript : MonoBehaviour
{
    public Slider slider;
    public Light sceneLight;
    
    public void Update()
    {
        sceneLight.intensity = slider.value;
    }
    
}
