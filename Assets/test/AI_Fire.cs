using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Fire : MonoBehaviour
{
    public GameObject AI;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider col)
    {
        //AI.transform.rotation = Player.transform.position;
        AI.transform.LookAt(Player.transform, Vector3.up);
        AI.GetComponent<Animator>().SetBool("Fire", true);
    }

    public void OnTriggerStay(Collider col)
    {
        AI.GetComponent<Animator>().SetBool("Fire", true);
        Invoke("DisableText", 5f);
    }

    public void OnTriggerExit(Collider col)
    {
        
    }

    public void DisableText()
    {
        Player.GetComponent<Health_Player>().Health = Player.GetComponent<Health_Player>().Health - 10;
    }
}
