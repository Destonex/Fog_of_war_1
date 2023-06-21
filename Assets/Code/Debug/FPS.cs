using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public static float fps;
    
    public void OnGUI()
    {
        fps = 1.0f / Time.deltaTime;
        GUI.Label(new Rect (25,25,100,100),  "FPS: " + (int)fps);
        //GUILayout.Label("FPS: " + (int)fps);
    }
    
}
