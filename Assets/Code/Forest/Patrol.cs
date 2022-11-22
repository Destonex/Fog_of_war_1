using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    private int pointIndex = 0;
    private float rotationSpeed;
    private float angleVectorsNew = 0;

    private List<Transform> points = new List<Transform>();
    private NavMeshAgent agent;
    private Transform agentTransform;
    private Transform Target;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        Transform pointObject = GameObject.FindGameObjectWithTag("Points").transform;
        foreach (Transform item in pointObject)
            points.Add(item);

        Target = points[1];
        gameObject.GetComponent<Animator>().SetBool("isPotroling", true);
        rotationSpeed = agent.angularSpeed;
        agentTransform = agent.transform;
        agent.SetDestination(points[0].position);
    }

    void Update()
    {
        RotateToTarget();
        if(agent.remainingDistance <= agent.stoppingDistance)
        {
            Target = points[pointIndex]; 
            agent.SetDestination(points[pointIndex++].position);
        }
 
        if(pointIndex == points.Count)
            pointIndex = 0;

    }
    
    private void RotateToTarget() 
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