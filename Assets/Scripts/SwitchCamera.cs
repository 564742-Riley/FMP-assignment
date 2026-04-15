using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchCamera : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    InputAction cameraAction;
    
   
    
    void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        cameraAction = InputSystem.actions.FindAction("Cameras");
    }

   
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            
        }

        if (Input.GetKeyDown("2"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            camera3.SetActive(false);

        }

        if (Input.GetKeyDown("3"))
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);

        }


    }
}