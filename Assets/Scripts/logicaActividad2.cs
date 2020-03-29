using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaActividad2 : MonoBehaviour
{
    
    private UnityEngine.AI.NavMeshAgent agent;
    public GameObject agentToFollow;

    Vector3 velocity = Vector3.zero;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowAgent();
    }

    public void FollowAgent() {
        //Pb
        Vector3 targetPosition = agentToFollow.GetComponent<Transform>().position;
        //Módulo del vector
        Vector3 playerDistance = (targetPosition - (Vector3)transform.position);        
        //Módulo velocidad deseado
        Vector3 desiredVelocity = playerDistance.normalized * 4f;


        Vector3 steering = desiredVelocity - velocity;


        velocity += steering * Time.deltaTime;
        
        agent.destination += velocity*Time.deltaTime;
        Debug.Log(agent.destination);
        
    }
}
