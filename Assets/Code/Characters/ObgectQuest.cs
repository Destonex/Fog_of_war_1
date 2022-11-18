using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObgectQuest : MonoBehaviour
{
    public Event_Play Qevent;
    private Dialog_Next Text1;
    public GameObject mosin;
    public GameObject PressStart;
    public GameObject map;
    
    public void Start()
    {
        mosin.SetActive(false);
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            PressStart.SetActive(true);
        }
        
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            if(Input.GetKeyDown("e"))
            {
                PressStart.SetActive(false);
                Qevent.end_Quest1 = true;
                mosin.SetActive(true);
                gameObject.SetActive(false);
                map.SetActive(false);
            }

        }

    }

    public void OnTriggerExit(Collider col)
    {
        PressStart.SetActive(false);
    }
}
