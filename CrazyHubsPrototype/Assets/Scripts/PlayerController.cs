using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 move;
    private float forwardSpeed = 10f;

    private int movementSection = 1; //0 1 2  
    private float sideStep = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    private void Update()
    {
        move.z = forwardSpeed;
        MovementMechanics();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(move * Time.fixedDeltaTime);
    }

   

    private void MovementMechanics()
    {
       
      

        if(SwipeManager.swipeLeft)
        {
            movementSection--;
            if (movementSection == -1)
                movementSection = 0;
        }

        if(SwipeManager.swipeRight)
        {
            movementSection++;
            if (movementSection == 3)
                movementSection = 2;
        }

        CalculatePosition();
    }

    private void CalculatePosition()
    {
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (movementSection == 0)
            targetPosition += Vector3.left * sideStep;
        else if (movementSection == 2)
            targetPosition += Vector3.right * sideStep;

        //transform.position = targetPosition;

        if (transform.position != targetPosition)
        {
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDir = diff.normalized * 30 * Time.deltaTime;
            if (moveDir.sqrMagnitude < diff.magnitude)
                controller.Move(moveDir);
            else
                controller.Move(diff);
        }
    }
}
