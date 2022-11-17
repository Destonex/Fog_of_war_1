using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegistrationHits : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject mosin;
    public  int tt1 = 0;
    public int tt2 = 0;
    public int tt3 = 0;
    private ObgectQuest obgectQuest;
    public NewShooting newShooting;
    public GameObject Ammo;
    
    void Start()
    {
        target1.SetActive(false);
        target2.SetActive(false);
        target3.SetActive(false);
        Ammo.SetActive(false);
    }

    void Update()
    {
        tt1 = newShooting.t1; 
        tt2 = newShooting.t2;
        tt3 = newShooting.t3; 

       if(mosin.activeSelf == true)
       {
        target1.SetActive(true);
        target2.SetActive(true);
        target3.SetActive(true);
        Ammo.SetActive(true);
       }

       f_HitTarget1();
       f_HitTarget2();
       f_HitTarget3();
    }

    public void f_HitTarget1()
    {
        if(tt1<4)
            target1.GetComponent<Text>().text = "Первая мишень "+tt1+"/3";
    }
    
    public void f_HitTarget2()
    {
        if(tt2<4)
            target2.GetComponent<Text>().text = "Вторая мишень "+tt2+"/3";
    }
    
    public void f_HitTarget3()
    {
        if(tt3<4)
            target3.GetComponent<Text>().text = "Третья мишень "+tt3+"/3";
    }
}
