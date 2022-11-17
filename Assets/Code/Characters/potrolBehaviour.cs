using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;


public class potrolBehaviour : StateMachineBehaviour
{
    float timer;
    List<Transform> points = new List<Transform>();
    NavMeshAgent agent;
    int i = 0;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        Transform pointsObject = GameObject.FindGameObjectWithTag("Points").transform;
        foreach (Transform t in pointsObject)
            points.Add(t);

        agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(points[i].position);
    }

 
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(i == points.Count)
            i = 0;

        if (agent.remainingDistance <= agent.stoppingDistance)
        {                   
            agent.SetDestination(points[i++].position);
        }
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       agent.SetDestination(agent.transform.position);
    }

}
