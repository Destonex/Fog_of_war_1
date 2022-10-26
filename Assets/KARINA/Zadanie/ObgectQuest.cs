using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObgectQuest : MonoBehaviour
{
    public Event_Play Qevent;
    public GameObject mosin;
    private Dialog_Next Text1;
    //private NPC_Task PressStart;
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
        if (col.tag == "Player" && Text1 == true){
            //NPC_Task.PressStart.SetActive(true);
            if(Input.GetKeyDown("e")){
               // NPC_Task.PressStart.SetActive(false);
                Qevent.end_Quest1 = true;
                mosin.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        //NPC_Task.PressStart.SetActive(false);
    }
}
