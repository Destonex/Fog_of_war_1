using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_scripts : MonoBehaviour
{
   public GameObject exitPanel;
   public GameObject settingPanel;
   public GameObject CollecthionPanel;
   public GameObject Button;
   //public GameObject Text;

   public void Update() {
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
    }
   public void StartGame(){
        SceneManager.LoadScene("Forest");
  }

   public void LoadGame(){
        SceneManager.LoadScene("Villege");
  }
    public void ExitGame(){
      Application.Quit();  
    }

    public void SettingPanel_true(){
      settingPanel.SetActive(true);  
      Button.SetActive(false);
      //Text.SetActive(false);
    }

    public void SettingPanel_false(){
      settingPanel.SetActive(false);  
      Button.SetActive(true);
      //Text.SetActive(true);
    }

    public void exitPanel_true(){
      exitPanel.SetActive(true);  
      Button.SetActive(false);
    }

    public void exitPanel_false(){
      exitPanel.SetActive(false);  
      Button.SetActive(true);
    }

    public void CollecthionPanel_true(){
      //CollecthionPanel.SetActive(true);  
      //Button.SetActive(false);
      SceneManager.LoadScene("Collection");

      //Text.SetActive(false);
    }

    public void CollecthionPanel_false(){
      CollecthionPanel.SetActive(false);  
      Button.SetActive(true);
      //Text.SetActive(true);
    }
}