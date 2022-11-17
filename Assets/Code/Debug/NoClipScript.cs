using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoClipScript : MonoBehaviour
{
    public GameObject EmptyNoclip;
    private Vector3 _angles;
    public float speed = 0.55f;
    public float fastSpeed = 1.25f;
    public float mouseSpeed = 2.5f;
    public CharacterController cc;
   
    public void Start()
    {
        cc = GetComponent<CharacterController>();
    }
 
    public void Update() 
    {
        if(!EmptyNoclip.activeInHierarchy)
        {
            cc.enabled=false; 
            NewCC();
        }
        else if (EmptyNoclip.activeInHierarchy)
        {
            cc.enabled=true; 
        }
    }

    public void NoclipButtonClick()
    {
        if(EmptyNoclip.activeInHierarchy == true)
        {
            EmptyNoclip.SetActive(false);
        }
        else
        {
            EmptyNoclip.SetActive(true);
        }
    }

   void NewCC()
   {
    _angles.x -= Input.GetAxis("Mouse Y") * mouseSpeed;
    _angles.y += Input.GetAxis("Mouse X") * mouseSpeed;
    transform.eulerAngles = _angles;
    float moveSpeed = Input.GetKey(KeyCode.LeftShift) ? fastSpeed : speed;
       transform.position +=
           Input.GetAxis("Horizontal") * moveSpeed * transform.right +
           Input.GetAxis("Vertical") * moveSpeed * transform.forward;
   }
}
