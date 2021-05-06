using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Transform targetMaker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int button = 0;

        // get the point of the hit position when the mouse is being clicked
        if(Input.GetMouseButtonDown(button)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo)){
                Vector3 targetPosition = hitInfo.point;
                targetMaker.position = targetPosition;
            }
        }
        
    }
}
