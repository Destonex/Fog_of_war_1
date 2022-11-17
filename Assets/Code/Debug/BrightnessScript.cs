using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessScript : MonoBehaviour
{
    public Slider slider;
    public Light sceneLight;
    
    void Update()
    {
        sceneLight.intensity = slider.value;
    }
}
