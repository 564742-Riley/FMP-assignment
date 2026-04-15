using UnityEngine;
using UnityEngine.InputSystem;

public class Car: MonoBehaviour
{
    public CarBasicMovement InputActions;

    public Rigidbody rigid;
    public WheelCollider wheel1, wheel2, wheel3, wheel4;
    public float drivespeed, steerspeed;
    float horizontalInput, verticalInput;
    InputAction moveAction;
    InputAction attackAction;
    InputAction steerAction;
    InputAction accelerateAction;
    InputAction brakeAction;



    void Start()
    {

        // steer action
        // accelerate -1 to -0.1
        // brake 0.1 to 1

        //moveAction = InputSystem.actions.FindAction("Move");


        accelerateAction = InputSystem.actions.FindAction("Accelerate");
        brakeAction = InputSystem.actions.FindAction("Brake");
        steerAction = InputSystem.actions.FindAction("Steer");
        
        accelerateAction.Enable();
        brakeAction.Enable();
        steerAction.Enable();

        if (accelerateAction == null )
        {
            print("Accelerate action not found");
        }


        if (brakeAction == null)
        {
            print("Brake action not found");
        }
    }
     
    


    void Update()
    {
        GetInput();


        

       
    }

    void GetInput()
    {
        
        
            horizontalInput = steerAction.ReadValue<float>();

            float accel = accelerateAction.ReadValue<float>();
            float brake = brakeAction.ReadValue<float>();

            // Combine triggers into forward/back
            verticalInput = accel - brake;

            Debug.Log($"Steer: {horizontalInput} | Accel: {accel} | Brake: {brake} | Final: {verticalInput}");
            

    }




    void FixedUpdate()
    {

        float motor = verticalInput * drivespeed;
        wheel1.motorTorque = motor;
        wheel2.motorTorque = motor;
        wheel3.motorTorque = motor;
        wheel4.motorTorque = motor;
        wheel1.steerAngle = steerspeed * horizontalInput;
        wheel2.steerAngle = steerspeed * horizontalInput;
    }

}