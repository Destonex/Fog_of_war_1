using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Play : MonoBehaviour
{
    public bool Quest1;
    public GameObject Text1;
    public bool end_Quest1;

    public void Update()
    {
        if (end_Quest1 == false)
        {
            if (Quest1 == true)
            {
                Text1.SetActive(true);
            }
            else
            {
                Text1.SetActive(false);
            }

        }
        else
        {
            Text1.SetActive(false);
        }
        
    }
}
