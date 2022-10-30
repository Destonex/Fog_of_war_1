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
    // Start is called before the first frame update
    void Start()
    {
        mosin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" /*&& Text1 == true*/){
            //npcTask.f_PressStart_On();
            PressStart.SetActive(true);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" /*&& Text1 == true*/){
            //npcTask.f_PressStart_On();
            if(Input.GetKeyDown("e")){
                //npcTask.f_PressStart_Off();
                PressStart.SetActive(false);
                Qevent.end_Quest1 = true;
                mosin.SetActive(true);
                //Destroy(gameObject);
                gameObject.SetActive(false);
                map.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        //npcTask.f_PressStart_Off();
        PressStart.SetActive(false);
    }
}
