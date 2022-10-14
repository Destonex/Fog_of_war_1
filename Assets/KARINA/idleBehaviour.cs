using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class idleBehaviour : StateMachineBehaviour
{
    float timer;
    Transform player;
    float runRange = 50;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       timer = 0;

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       float distance = Vector3.Distance(animator.transform.position, player.position);
       timer += Time.deltaTime;
       if (timer > 10)
       {
        animator.SetBool("isPotroling", true);
       }

        
        if (distance < runRange)
            animator.SetBool("isRun", true);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }
}
