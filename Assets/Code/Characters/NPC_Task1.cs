using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task1 : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog3;
    public GameObject PressStart;

    //public Animator anim;

    public void Update()
    {
        if (EndDialog == true)
        {
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
            // gameObject.GetComponent<Animator>().SetBool("MaxTalking 0", true);
            Dialog3.SetActive(true);
            PressStart.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        PressStart.SetActive(false);
    }

    // public void Update()
    // {
    //     if (EndDialog == true)
    //     {
    //         Dialog3.SetActive(false);
    //     }
    // }

    // public void OnTriggerEnter(Collider col)
    // {
    //     EndDialog = false;
    //     PressStart.SetActive(true);
    // }

    // public void OnTriggerStay(Collider col)
    // {
    //     if (col.tag == "Player" && Input.GetKeyDown("e"))
    //     {
    //         Dialog3.SetActive(true);
    //         PressStart.SetActive(false);
    //         anim.SetTrigger("MaxTalking");
    //     }
    // }

    // public void OnTriggerExit(Collider col)
    // {
    //     PressStart.SetActive(false);
    // }
}
