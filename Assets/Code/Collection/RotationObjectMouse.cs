using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObjectMouse : MonoBehaviour
{
    public float rotSpeed = 20;
    
    public void Update()
    {
       transform.Rotate(0, 0.1f, 0);
    }
}
