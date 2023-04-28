using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class StopMenu : MonoBehaviour
{
  public KeyCode button;
  public GameObject Stop_menu;
  private bool active = false;
  public GameObject Player;
  public GameObject Camera;
  private loading_scene_slider loadingSceneSlider;
  public FirstPersonController firstPersonController;
  public GameObject Debug;
  private bool t = false;

  void Start()
  {
    //firstPersonController = Player.GetComponent<FirstPersonController>();
    //firstPersonController.enabled = true;  
  }

  public void Update() 
  {
    if (!Input.GetKeyDown(button)) return;
    
    if (active == false) 
    {
      Debug.SetActive(false);
      t=true;
      Time.timeScale = 0;
      Stop_menu.SetActive(true);
      Cursor.visible = true;
      Player.SetActive(false);
      Camera.SetActive(true);
      //firstPersonController.enabled = false;  
      Cursor.lockState = CursorLockMode.None;
      active = true;
    }
    else
    {
      Debug.SetActive(true);
      t=false;
      Cursor.visible = false;
      Time.timeScale = 1;
      Stop_menu.SetActive(false);
      Player.SetActive(true);
      Camera.SetActive(false);
      //firstPersonController.enabled = true;  
      active= false;
    }


        if(t==true)
        {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

  }
  public void Exit()
  {
    SceneManager.LoadScene("Loading");
	  loading_scene_slider.sceneID = 0;
  }

  public void Resume()
  {
    Debug.SetActive(true);
    Cursor.visible = false;
    Time.timeScale = 1;
    Stop_menu.SetActive(false);
    Player.SetActive(true);
    Camera.SetActive(false);
    //firstPersonController.enabled = true;   
  }
 
  public void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}