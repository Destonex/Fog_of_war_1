using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class runBehaviour : StateMachineBehaviour
{
    private NavMeshAgent agent;
    private Transform player;
    private float attackRange = 30;
    private float runRange = 50;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = animator.GetComponent<NavMeshAgent>();
        agent.speed = 20;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(player.position);
        float distance = Vector3.Distance(animator.transform.position, player.position);
        if (distance < attackRange)
            animator.SetBool("isAttack", true);

        if (distance > 50)
            animator.SetBool("isRun", false);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
        agent.speed = 8;
    }
}
