using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : MonoBehaviour
{
    public Transform targetTransform;
    public float targetDistanceTolerance = 3.0f;

    private float movementSpeed;
    private float rotationSpeed;

    private void Start(){
        movementSpeed = 10.0f;
        rotationSpeed = 2.0f;
    }

    private void Update(){

        if(Vector3.Distance(transform.position, targetTransform.position) < targetDistanceTolerance){
            return;
        }

        Vector3 targetPosition = targetTransform.position;
        targetPosition.y = transform.position.y; 
        Vector3 direction = targetPosition - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.Translate(new Vector3(0, 0, movementSpeed * Time.deltaTime));

            
    }
}
