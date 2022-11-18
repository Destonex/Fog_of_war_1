using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ShadedWireframes : MonoBehaviour
{
    public Button ShadedWireframe; 
    public bool WireframeIndicator=true;
   
    public void ShadedWireframeOn()
    {
        if (WireframeIndicator==true)
            WireframeIndicator=false;
        else if (WireframeIndicator==false)
            WireframeIndicator = true;    

    }

    public void OnPreRender()
    {
        if(WireframeIndicator==false)
               GL.wireframe = true;

    }

}
