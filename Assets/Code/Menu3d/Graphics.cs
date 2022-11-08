using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Graphics : MonoBehaviour
{
    public Dropdown graphics;
    public Dropdown resol;
    public Toggle toggle;
    Resolution[] res;

    void Start()
    {
        Screen.fullScreen = true;
        toggle.isOn = false;


        //Graphics
        graphics.ClearOptions();
       graphics.AddOptions(QualitySettings.names.ToList());
        // dropDown.value = QualitySettings.GetQualityLevel(); //������� ��� � Unity
        // dropDown.value = 2;//������� medium

        //Resolution
        Resolution[] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();
        string[] strRes = new string[res.Length];

        for (int i = 0; i < res.Length; i++)
        {
            // strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString();//����������� ��� Ghz
             strRes[i] = res[i].ToString();
        }
        resol.ClearOptions();
        resol.AddOptions(strRes.ToList());
        
        if (PlayerPrefs.HasKey("Quality") || PlayerPrefs.HasKey("Resolution") || PlayerPrefs.HasKey("FullScreen"))
        {
            graphics.value = PlayerPrefs.GetInt("Quality");
            resol.value = PlayerPrefs.GetInt("Resolution");

            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality"));
            Screen.SetResolution(res[PlayerPrefs.GetInt("Resolution")].width, res[PlayerPrefs.GetInt("Resolution")].height, Screen.fullScreen);
            if (PlayerPrefs.GetInt("FullScreen") == 0)
            {
                Screen.fullScreen = false;
                toggle.isOn = !Screen.fullScreen;
            }
            else
            {
                Screen.fullScreen = true;
                toggle.isOn = !Screen.fullScreen;
            }
        }
        else
        {
            graphics.value = QualitySettings.GetQualityLevel();
           Screen.SetResolution(res[res.Length - 1].width, res[res.Length - 1].height, Screen.fullScreen);
            resol.value = res.Length - 1;

            Screen.fullScreen = true;
            toggle.isOn = !Screen.fullScreen;
        }
    }

    public void SetQuality(){
        QualitySettings.SetQualityLevel(graphics.value);
        PlayerPrefs.SetInt("Quality", graphics.value);
    }

    public void SetRes()
    {
        Screen.SetResolution(res[resol.value].width, res[resol.value].height, Screen.fullScreen);
        PlayerPrefs.SetInt("Resolution", resol.value);
    }
 
    public void ScreenMode()
    {
        Screen.fullScreen = !toggle.isOn;
        if (Screen.fullScreen)
        {
            PlayerPrefs.SetInt("FullScreen", 1);
        }
        else
        {
            PlayerPrefs.SetInt("FullScreen", 0);
        }
    }
}