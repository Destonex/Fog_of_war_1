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

    public bool CascadedShadowsIndicator=true;

    Button btn;


    public void CascadedShadowsOn()
    {
         //DrawCameraMode drawMode = k;
         //GameView.lastActiveGameView.cameraMode = GameView.GetBuiltinCameraMode(k);
         SceneView.lastActiveSceneView.cameraMode = SceneView.GetBuiltinCameraMode(k);
        if (CascadedShadowsIndicator==true)
        {
             //k = DrawCameraMode.ShadowCascades;
            CascadedShadowsIndicator=false;
        }
        else if (CascadedShadowsIndicator==false)
        {
            // k = DrawCameraMode.ShadowCascades;
            CascadedShadowsIndicator=true;
        }

        if(CascadedShadowsIndicator==false)
            k = DrawCameraMode.ShadowCascades;
        else
            k = DrawCameraMode.Textured;
        //ActiveOrNot();
    }
//  void OnPreRender()
//     {
//         if(CascadedShadowsIndicator==false)
//                GL.hadowCascades = true;
//     }
    void Start()
    {

    }

    void Update()
    {

    }

    void ActiveOrNot()
    {
    //     if(EmptyShadowCascades.activeInHierarchy == true){
    //         EmptyShadowCascades.SetActive(false);
    //     }
    //     else
    //     {
    //         EmptyShadowCascades.SetActive(true);
    //     }


    }
}
