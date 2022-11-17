using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coordinates : MonoBehaviour
{
    public Text X;
    public Text Y;
    public Text Z;
    float x;
    float y;
    float z;

    void Start()
    {
        X.text = "0";
        Y.text = "0";
        Z.text = "0";
    }

    void Update()
    {
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        z = gameObject.transform.position.z;
        
        X.text = x.ToString();
        Y.text = y.ToString();
        Z.text = z.ToString();
    }
}
