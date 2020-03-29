using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaActividad1 : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;
    public bool isMoving = false;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(camRay, out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
        
    }
}
