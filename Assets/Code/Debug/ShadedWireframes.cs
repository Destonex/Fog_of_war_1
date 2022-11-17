using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ShadedWireframes : MonoBehaviour
{
    public Button ShadedWireframe; 
    public bool WireframeIndicator=true;
    Button btn;
   
    public void ShadedWireframeOn()
    {
        if (WireframeIndicator==true)
            WireframeIndicator=false;
        else if (WireframeIndicator==false)
            WireframeIndicator = true;     
    }

    void OnPreRender()
    {
        if(WireframeIndicator==false)
               GL.wireframe = true;
    }
}
