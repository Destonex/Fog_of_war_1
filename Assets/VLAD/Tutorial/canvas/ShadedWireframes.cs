using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.EventSystems;

//using UnityEditor.GameView;

public class ShadedWireframes : MonoBehaviour
{
    public DrawCameraMode k;
    public Button ShadedWireframe; 

    public bool WireframeIndicator=true;

    Button btn;
   
    public void ShadedWireframeOn()
    {
         //k = DrawCameraMode.Wireframe;
         //SceneView.lastActiveSceneView.cameraMode = SceneView.GetBuiltinCameraMode(k);

        if (WireframeIndicator==true)
        {
            WireframeIndicator=false;
        }
        else if (WireframeIndicator==false)
        {
            WireframeIndicator=true;
        }
    }

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    void OnPreRender()
    {
        if(WireframeIndicator==false)
               GL.wireframe = true;
    }
}
