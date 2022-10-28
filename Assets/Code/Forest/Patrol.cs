using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    int pointIndex = 0;
    public List<Transform> points = new List<Transform>();
    public NavMeshAgent agent;

    public Transform agentTransform;
    public Transform Target;
    
    private float rotationSpeed;
    void Start()
    {
       Transform pointObject = GameObject.FindGameObjectWithTag("Points").transform;
        foreach (Transform item in pointObject)
            points.Add(item);
        Target = points[1];
          
            gameObject.GetComponent<Animator>().SetBool("isPotroling", true);
    
        rotationSpeed = agent.angularSpeed;
        agentTransform = agent.transform;
        //agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(points[0].position);
    }

    void Update()
    {
        RotateToTarget();
       if(agent.remainingDistance <= agent.stoppingDistance){
           Target = points[pointIndex]; 
            agent.SetDestination(points[pointIndex++].position);
            //gameObject.GetComponent<Animator>().SetBool("Walk", true);
            
       }
 
        if(pointIndex == points.Count)
            pointIndex = 0;
    }

    private void RotateToTarget() // поворачивает в стороно цели со скоростью rotationSpeed
    {
        Vector3 lookVector = Target.position - agentTransform.position;
        lookVector.y = 0;
        if (lookVector == Vector3.zero) return;
        agentTransform.rotation = Quaternion.RotateTowards
            (
                agentTransform.rotation,
                Quaternion.LookRotation(lookVector , Vector3.up),
                rotationSpeed * Time.deltaTime
            );
        
    }
}
