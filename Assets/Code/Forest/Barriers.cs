using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barriers : MonoBehaviour
{
    private Vector3 initialPosition;
    public bool isInsideTrigger;
    public Transform Player;

    private void Start()
    {
        initialPosition = Player.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideTrigger = true;
            Invoke("ResetPosition", 5f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideTrigger = false;
            CancelInvoke("ResetPosition");
        }
    }

    private void ResetPosition()
    {
        if (isInsideTrigger)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
