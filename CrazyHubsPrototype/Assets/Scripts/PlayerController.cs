using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float forwardSpeed = 2f;
    private int movementSection = 1; //0 1 2  
    private float sideStep = 2.5f;
    private float gravityModifier = 2f;
    private float playersY = 1.57f;

    public float ForwardSpeed { get => forwardSpeed; set => forwardSpeed = value; }

    private void Start()
    {
        Physics.gravity *= gravityModifier;
        GroundIgnore();
       
    }

    private void Update()
    {
        MovementMechanics();
        FixPlayersPosition();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * forwardSpeed);
    }

    private void GroundIgnore()
    {
        foreach (var item in GameObject.FindGameObjectsWithTag("Ground"))
        {
            Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), item.GetComponent<Collider>(), true);
        }
    }

    private void FixPlayersPosition()
    {
        if(transform.position.y > playersY)
        {
            transform.position = new Vector3(transform.position.x, playersY, transform.position.z);
        }
    }

   

    private void MovementMechanics()
    { 
        if(SwipeManager.swipeLeft)
        {
            FindObjectOfType<SoundEffectManager>().PlaySound("Swipe");
            movementSection--;
            if (movementSection == -1)
                movementSection = 0;
            CalculatePosition();
        }

        if(SwipeManager.swipeRight)
        {
            FindObjectOfType<SoundEffectManager>().PlaySound("Swipe");
            movementSection++;
            if (movementSection == 3)
                movementSection = 2;
            CalculatePosition();
        }       
    }

    private void CalculatePosition()
    {
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (movementSection == 0)
            targetPosition += Vector3.left * sideStep;
        else if (movementSection == 2)
            targetPosition += Vector3.right * sideStep;

        transform.position = Vector3.Lerp(transform.position,targetPosition,2);

       
    }
}
