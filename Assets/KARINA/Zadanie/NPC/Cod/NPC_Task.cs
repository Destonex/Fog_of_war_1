using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class NPC_Task : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public Dialog_Next dialog_Next;
    public Event_Play quest;
    public bool end_Finish;
    public GameObject move;

    public GameObject PressStart;


    void Start()
    {

    }

    void Update()
    {
        //if (quest.end_Quest1 == true)
        //{
        //   end_Finish = true;
        //}

        if (EndDialog == true)
        {
            if (dialog_Next.active == false)
                quest.Quest1 = true;
            Dialog1.SetActive(false);
        }
        if (end_Finish == true) 
        {
            quest.Quest1 = false;
            PressStart.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        EndDialog = false;
        PressStart.SetActive(true);
    }

    void OnTriggerStay(Collider col)
    {
        if (EndDialog == false )
        {
            if (col.tag == "Player" && Input.GetKeyDown("e"))
            {
                gameObject.GetComponent<Animator>().SetBool("Talking", true);
                move.GetComponent<FirstPersonController>().enabled = false;
                //move.GetComponent<Rigidbody>().useGravity = false;
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

    void OnTriggerExit(Collider col)
    {
        PressStart.SetActive(false);
    }
}
