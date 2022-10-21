using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu_scripts : MonoBehaviour
{
   public GameObject exitPanel;
   public GameObject settingPanel;
   public GameObject loadPanel;
   public GameObject Button;
   private string selected;
   
   public RawImage map_foto;

   public Texture Forest_foto;
   public Texture Village_foto;
   public Texture Polotsk_foto; 
   //public GameObject Text;

    public void Update() {
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
    }
    public void StartGame(){
      SceneManager.LoadScene("Forest");
    }

    public void LoadGame(){
      SceneManager.LoadScene(selected);
    }

    public void ForestSelected(){
      selected = "Forest";
      map_foto.GetComponent<RawImage>().texture = Forest_foto; 
    }

    public void VillageSelected(){
      selected = "Village";
      map_foto.GetComponent<RawImage>().texture  = Village_foto; 
    }

    public void PolotskSelected(){
      selected = "Polotsk_A1";
      map_foto.GetComponent<RawImage>().texture = Polotsk_foto; 
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

    public void LoadPanel_true(){
      loadPanel.SetActive(true);  
      Button.SetActive(false);
    }

    public void LoadPanel_false(){
      loadPanel.SetActive(false);  
      Button.SetActive(true);
    }

    public void CollecthionScene(){
      SceneManager.LoadScene("Collection");
    }
}