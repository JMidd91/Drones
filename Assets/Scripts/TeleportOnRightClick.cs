using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnRightClick : MonoBehaviour
{
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                newPosition = hit.point;
                transform.position = newPosition;
            }
        }
    }
}
