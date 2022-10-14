using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.EventSystems;
using Unity.Rendering;

public class CascadedShadows : MonoBehaviour
{
    public DrawCameraMode k;
    public Button CascadedShadow;

    public GameObject EmptyShadowCascades;

    public bool CascadedShadowsIndicator=false;

    public void CascadedShadowsOn()
    {    
        ActiveOrNot();
        //GameView.lastActiveGameView.cameraMode = GameView.GetBuiltinCameraMode(k);
         SceneView.lastActiveSceneView.cameraMode = SceneView.GetBuiltinCameraMode(k);
        if(CascadedShadowsIndicator==true)
            k = DrawCameraMode.ShadowCascades;
        else
            k = DrawCameraMode.Textured;
        
    }

    void ActiveOrNot()
    {
        if (EmptyShadowCascades.activeInHierarchy == true)
        {
            EmptyShadowCascades.SetActive(false);
            CascadedShadowsIndicator = true;
        }
        else
        {
            EmptyShadowCascades.SetActive(true);
            CascadedShadowsIndicator = false;

        }


    }
}
