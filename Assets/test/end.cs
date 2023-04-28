using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public GameObject r1;
    public GameObject r2;
    public GameObject r3;
    public GameObject endc;

    public GameObject Player;
    public GameObject Camera;

    public GameObject Debug;
    public GameObject StopM;
    // Start is called before the first frame update
    void Start()
    {
        endc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(r1.activeSelf && r2.activeSelf && r3.activeSelf)
        {
            Debug.SetActive(false);
            StopM.SetActive(false);
            endc.SetActive(true);
            Player.SetActive(false);
            Camera.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
