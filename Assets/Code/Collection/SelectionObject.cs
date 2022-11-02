using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionObject : MonoBehaviour
{
    [Header("Николаевский собор")]
    public GameObject NicholasCathedral;
    public GameObject TextNicholasCathedral;

    [Header("Трубка связного")]
    public GameObject Tube;
    public GameObject TextTube;

    [Header("Дом красной армии")]
    public GameObject DomKrasnoyArmy;
    public GameObject TextDomKrasnoyArmy;

    [Header("Здание комендатуры")]
    public GameObject CommandantsOffice;
    public GameObject TextCommandantsOffice;

    [Header("Солдатский клуб")]
    public GameObject soldiersClub;
    public GameObject TextDom;

    public void f_NicholasCathedral(){
        NicholasCathedral.SetActive(true);
        TextNicholasCathedral.SetActive(true);
        Tube.SetActive(false);
        TextTube.SetActive(false);
    }

    public void f_Tube(){
        NicholasCathedral.SetActive(false);
        TextNicholasCathedral.SetActive(false);
        Tube.SetActive(true);
        TextTube.SetActive(true);
    }

    public void f_Exit_Menu(){
      SceneManager.LoadScene("Menu3d");
    }
   /* void Start()
    {
        
    }

    void Update()
    {
        
    }*/
}
