using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Player;
    void Start()
    {
        Camera.transform.position = Player.transform.position;
        Camera.transform.rotation = Player.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.position = Player.transform.position;
        Camera.transform.rotation = Player.transform.rotation;
    }
}
