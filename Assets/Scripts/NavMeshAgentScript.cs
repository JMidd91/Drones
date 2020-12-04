using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshAgentScript : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    private Vector3 currentDestination;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // need to add a check for "if character is selected" or something similar.
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                SetNewDestination(hit.point);
            }
        }

        agent.SetDestination(currentDestination);
    }

    public void SetNewDestination(Vector3 newPosition)
    {
        currentDestination = newPosition;
    }
}
