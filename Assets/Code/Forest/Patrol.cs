using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    int pointIndex = 0;
    private List<Transform> points = new List<Transform>();
    private NavMeshAgent agent;

    private Transform agentTransform;
    private Transform Target;

    private float rotationSpeed;
    float g;
    private float angleVectorsNew = 0;
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


        //agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(points[0].position);
    }

    void Update()
    {
        RotateToTarget();
        
            gameObject.GetComponent<Animator>().SetBool("isR", false);
            gameObject.GetComponent<Animator>().SetBool("isL", false);
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


        Vector3 agentPos = agentTransform.position - new Vector3(agentTransform.position.x, agentTransform.position.y, agentTransform.position.z + 1);
        //Debug.Log(agentPos);

        float scalarProductVectors = lookVector.x * agentPos.x + lookVector.z * agentPos.z;
        float vectorModules1 = Mathf.Sqrt(Mathf.Pow(lookVector.x, 2.0f) + Mathf.Pow(lookVector.z, 2.0f));
        float vectorModules2 = Mathf.Sqrt(Mathf.Pow(agentPos.x, 2.0f) + Mathf.Pow(agentPos.z, 2.0f));       

        float angleVectors = scalarProductVectors / (vectorModules1 * vectorModules2);


        
        angleVectorsNew = /*angleVectorsNew +*/ angleVectors;

        Debug.Log(angleVectorsNew);

        if (angleVectorsNew <= -30){
            gameObject.GetComponent<Animator>().SetBool("isR", true);

        }
        else if(angleVectorsNew >= 30)
        {
            gameObject.GetComponent<Animator>().SetBool("isL", true);
            
        }//*/
        

        //раскомитеть
        //lookVector.y = 0;
        /*if (lookVector == Vector3.zero) return;

        agentTransform.rotation = Quaternion.RotateTowards
            (
                agentTransform.rotation,
                Quaternion.LookRotation(lookVector , Vector3.up),
                rotationSpeed * Time.deltaTime
            );//*/
    }
}