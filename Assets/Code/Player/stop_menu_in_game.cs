using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class stop_menu_in_game : MonoBehaviour
{
  public KeyCode button;
  public GameObject Stop_menu;
  private bool active = false;
  public GameObject Player;
  private loading_scene_slider loadingSceneSlider;

  void Start()
  {
    Player.GetComponent<FirstPersonController>().enabled = true;  
  }

  public void Update() 
  {
    if (Input.GetKeyDown(button) && active == false) 
    {
      Time.timeScale = 0.0f;
      Stop_menu.SetActive(true);
      Cursor.visible = true;
      Player.GetComponent<FirstPersonController>().enabled = false;  
      Cursor.lockState = CursorLockMode.None;
      active = true;
    }
    else if (Input.GetKeyDown(button) && active == true)
    {
      Cursor.visible = false;
      Time.timeScale = 1.0f;
      Stop_menu.SetActive(false);
      Player.GetComponent<FirstPersonController>().enabled = true;  
      active= false;
    }
  }
  public void Exit()
  {
    SceneManager.LoadScene("Loading");
	  loading_scene_slider.sceneID = 0;
  }

  public void Resume()
  {
    Cursor.visible = false;
    Time.timeScale = 1.0f;
    Stop_menu.SetActive(false);
    Player.GetComponent<FirstPersonController>().enabled = true;    
  }
 
  public void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}