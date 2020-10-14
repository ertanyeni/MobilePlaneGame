using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
   
    public WheelJoint2D Wheel;

    public Rigidbody2D PlaneBody;

    private float Movement;
    private float Rotation;


    private void Update()
    {
        //Movement = -Input.GetAxisRaw("Vertical") * MovementSpeed;
        //Rotation = Input.GetAxisRaw("Horizontal");

        if (PlaneController.isRaceBtnDown == true)
        {
            Movement = 1 * MovementSpeed;
        }
        else if (PlaneController.isBrakeBtnDown == true)
        {
            Movement = -1 * MovementSpeed;
        }
        else
        {
            Movement = 0;
        }
    }
    
    

    private void FixedUpdate()
    {
        if (Movement == 0)
        {
            Wheel.useMotor = false;
        }
        else
        {
            Wheel.useMotor = true;

            JointMotor2D motor2d = new JointMotor2D { motorSpeed = Movement, maxMotorTorque = 10000 };
            Wheel.motor = motor2d;
        }

        PlaneBody.AddTorque(Rotation * RotationSpeed * Time.deltaTime);
    }
}
