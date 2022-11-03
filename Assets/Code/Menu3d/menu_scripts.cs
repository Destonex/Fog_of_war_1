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
   private int selected;
   
   public RawImage map_foto;

   public Texture Forest_foto;
   public Texture Village_foto;
   public Texture Polotsk_foto; 
   public Text Description;
   public string ForestDescription;
   public string VillageDescription;
   public string PolotskDescription;
   public loading_scene_slider loadingSceneSlider;

    public void Start(){
      selected = 1;
      // map_foto.GetComponent<RawImage>().texture = Forest_foto;
       Description.GetComponent<Text>().text = ForestDescription; 
    }

    public void Update() {
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
    }
    public void StartGame(){
      SceneManager.LoadScene("Loading");
      loading_scene_slider.sceneID = 1;
    }

    public void LoadGame(){
      SceneManager.LoadScene("Loading");
      loading_scene_slider.sceneID = selected;
    }

    public void ForestSelected(){
      selected = 1;
      map_foto.GetComponent<RawImage>().texture = Forest_foto;
      Description.GetComponent<Text>().text = ForestDescription; 
    }

    public void VillageSelected(){
      selected = 2;
      map_foto.GetComponent<RawImage>().texture  = Village_foto; 
      Description.GetComponent<Text>().text = VillageDescription; 
    }

    public void PolotskSelected(){
      selected = 3;
      map_foto.GetComponent<RawImage>().texture = Polotsk_foto; 
      Description.GetComponent<Text>().text = PolotskDescription; 
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