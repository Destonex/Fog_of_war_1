using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Emeny : MonoBehaviour
{
    public float Health = 100f;
    public GameObject bullet;

    public void TakeDamage(float amount){
        Health = Health - amount;
        if(Health<=0)
            Die();
    }

    private void Die() 
    {
        Destroy(gameObject);
    }
}
