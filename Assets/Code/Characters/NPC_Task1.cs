using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task1 : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog3;
    public GameObject PressStart;

    public void Update()
    {
        if (EndDialog == true)
        {
            Time.timeScale = 1;
            Dialog3.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        EndDialog = false;
        PressStart.SetActive(true);
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && Input.GetKeyDown("e"))
        {
            Time.timeScale = 0;
            Dialog3.SetActive(true);
            PressStart.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        PressStart.SetActive(false);
    }
}
