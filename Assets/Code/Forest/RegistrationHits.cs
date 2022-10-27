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
    public  int t1 = 0;
    public int t2 = 0;
    public int t3 = 0;
    private ObgectQuest obgectQuest;
    private NewShooting newShooting;

    // Start is called before the first frame update
    void Start()
    {
        target1.SetActive(false);
        target2.SetActive(false);
        target3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //t1 = newShooting.t1; 
        //t2 = newShooting.t2;
       // t3 = newShooting.t3; 

       if(mosin.activeSelf == true){
        target1.SetActive(true);
        target2.SetActive(true);
        target3.SetActive(true);
       }

       f_HitTarget1();
       f_HitTarget2();
       f_HitTarget3();
    }

    public void f_HitTarget1()
    {
        if(t1<4)
            target1.GetComponent<Text>().text = "первая мешень "+t1+"/3";
    }
    
    public void f_HitTarget2()
    {
        if(t2<4)
            target2.GetComponent<Text>().text = "вторая мешень "+t2+"/3";
    }
    
    public void f_HitTarget3()
    {
        if(t3<4)
            target3.GetComponent<Text>().text = "третья мешень "+t3+"/3";
    }
}
