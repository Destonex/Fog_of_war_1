using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Sound : MonoBehaviour
{
    public Slider slider;

    private AudioSource audioSrc;
    private float musicVolume;
    private float vol;

    public void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("Volum"))
        {
            musicVolume = PlayerPrefs.GetFloat("Volum");
            slider.value = PlayerPrefs.GetFloat("Volum");
        }
        else
        {
            musicVolume = 1f;
            slider.value = 1f;
        }

    }

    public void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("Volum", musicVolume);
    }
}
