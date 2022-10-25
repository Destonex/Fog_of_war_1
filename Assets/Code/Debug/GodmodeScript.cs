using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GodmodeScript : MonoBehaviour
{
    public GameObject hp;
    public GameObject EmptyGodmode;

    // Start is called before the first frame update
    void Start()
    {
       // hp = GetComponent<Health_Player>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!EmptyGodmode.activeInHierarchy)
        {
            hp.GetComponent<Health_Player>().enabled = false;

        }
        else if (EmptyGodmode.activeInHierarchy)
        {
            hp.GetComponent<Health_Player>().enabled = true;

        }
    }

    public void GodmodeOn()
    {
        if (EmptyGodmode.activeInHierarchy == true)
        {
            EmptyGodmode.SetActive(false);
        }
        else
        {
            EmptyGodmode.SetActive(true);
        }
    }
}
