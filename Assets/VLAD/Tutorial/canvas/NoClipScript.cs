using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoClipScript : MonoBehaviour
{
// //    public FirstPersonController fps;
   public GameObject NoclipScript;
   public GameObject EmptyNoclip;
   private Vector3 _angles;
   public float speed = 1.0f;
   public float fastSpeed = 2.0f;
   public float mouseSpeed = 4.0f;

    public CharacterController cc;
   public void Start()
    {
        cc = GetComponent<CharacterController>();
    }
 
   private void OnEnable() {
       //_angles = transform.eulerAngles;
       Cursor.lockState = CursorLockMode.Locked;
   }
 
   private void OnDisable() { 
    Cursor.lockState = CursorLockMode.None; 
   }
 
   private void Update() {
    if(!EmptyNoclip.activeInHierarchy)
    {
        cc.enabled=false; 
        //OnEnable();
        NewCC();
        
        //NoclipScript.enabled=false;
    }
    else if (EmptyNoclip.activeInHierarchy)
    {
        cc.enabled=true; 
        //OnDisable();
        
        //NoclipScript.enabled=true;
    }
    //NewCC();
   }

   public void NoclipButtonClick()
   {
        if(EmptyNoclip.activeInHierarchy == true){
            // // NoclipScript.GetComponent<FirstPersonController>().SetActive(false);
            EmptyNoclip.SetActive(false);
        }
        else
        {
        // //    NoclipScript.GetComponent<FirstPersonController>().SetActive(true);
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
