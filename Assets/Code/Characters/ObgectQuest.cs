using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObgectQuest : MonoBehaviour
{
    public Event_Play Qevent;
    public GameObject mosin;
    private Dialog_Next Text1;
    public GameObject PressStart;
    public GameObject map;
    
    void Start()
    {
        mosin.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            PressStart.SetActive(true);
        }
    }

    void OnTriggerStay(Collider col)
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

    void OnTriggerExit(Collider col)
    {
        PressStart.SetActive(false);
    }
}
