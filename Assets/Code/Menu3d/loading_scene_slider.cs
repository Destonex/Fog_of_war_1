using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loading_scene_slider : MonoBehaviour
{
    public static int sceneID;
    public Slider loadingImg;

   void Start()
   { 
        StartCoroutine(AsyncLoad());
   }

    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);

        while (!operation.isDone)
        {
            float progress = (operation.progress / 0.9f) * 100;
            loadingImg.value = progress;
            yield return null;
        }
    }
}


