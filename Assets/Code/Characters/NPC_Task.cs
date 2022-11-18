using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class NPC_Task : MonoBehaviour
{
    public bool EndDialog;
    public bool end_Finish;
    public Dialog_Next dialog_Next;
    public Event_Play quest;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public GameObject move;
    public GameObject PressStart;

    public void Update()
    {
        if (EndDialog == true)
        {
            if (dialog_Next.active == false)
                quest.Quest1 = true;

            Dialog1.SetActive(false);
        }

        if (end_Finish == true) 
        {
            quest.Quest1 = false;
        }

    }

    public void OnTriggerEnter(Collider col)
    {
        EndDialog = false;
        PressStart.SetActive(true);
    }

    public void OnTriggerStay(Collider col)
    {
        if (EndDialog == false )
        {
            if (col.tag == "Player" && Input.GetKeyDown("e"))
            {
                gameObject.GetComponent<Animator>().SetBool("Talking", true);
                if (quest.Quest1 == false)
                {
                    Dialog1.SetActive(true);
                }
                else if (quest.Quest1 == true)
                {
                    Dialog2.SetActive(true);
                }

                PressStart.SetActive(false);
            }
        }
    }

    public void OnTriggerExit(Collider col)
    {
        PressStart.SetActive(false);
    }

}
