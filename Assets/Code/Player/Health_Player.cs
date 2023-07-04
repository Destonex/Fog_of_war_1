using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Player : MonoBehaviour
{
    public int Health = 100;
    public Slider slider;
    public Text hp;
    public GameObject end;
    public GameObject camera;

    public void Update()
    {
        slider.value = Health;
        hp.text = string.Format("{0:0}", Health);
        if(Health<=0)
        {
            end.SetActive(true);
            camera.SetActive(true);
            gameObject.SetActive(false);
                        Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
