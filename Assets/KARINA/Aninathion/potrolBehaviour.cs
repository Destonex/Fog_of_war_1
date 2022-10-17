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

    Transform player;
    float runRange = 50;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       timer = 0;
       Transform pointsObject = GameObject.FindGameObjectWithTag("Points").transform;
       foreach (Transform t in pointsObject)
            points.Add(t);

        agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(points[0].position);

            player = GameObject.FindGameObjectWithTag("Player").transform;
    }

 
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if (agent.remainingDistance <= agent.stoppingDistance)
            agent.SetDestination(points[Random.Range(0, points.Count)].position);

       timer += Time.deltaTime;
       if (timer > 30)
        animator.SetBool("isPotroling", false);

        if(SceneManager.GetActiveScene().name != "Menu3d"){
            float distance = Vector3.Distance(animator.transform.position, player.position);
            if (distance < runRange)
                animator.SetBool("isRun", true);
        }
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       agent.SetDestination(agent.transform.position);
    }

}
