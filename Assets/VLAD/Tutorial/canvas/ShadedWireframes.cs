using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.EventSystems;

public class ShadedWireframes : MonoBehaviour
{
    public DrawCameraMode k;
    public Button ShadedWireframe; 

    public bool WireframeIndicator=true;

    Button btn;
   
    public void ShadedWireframeOn()
    {
         DrawCameraMode drawMode = k;
         SceneView.lastActiveSceneView.cameraMode = SceneView.GetBuiltinCameraMode(drawMode);

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
