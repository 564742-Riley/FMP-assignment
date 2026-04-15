using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchCamera : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;

    private InputAction cycleAction;

    private int currentCamera = 0; // 0 = cam1, 1 = cam2, 2 = cam3

    void Start()
    {
        cycleAction = InputSystem.actions.FindAction("CycleCamera");
        cycleAction.Enable();

        ActivateCamera(currentCamera);
    }

    void Update()
    {
        if (cycleAction.triggered)
        {
            currentCamera++;

            if (currentCamera > 2)
                currentCamera = 0;

            ActivateCamera(currentCamera);
        }
    }

    void ActivateCamera(int index)
    {
        camera1.SetActive(index == 0);
        camera2.SetActive(index == 1);
        camera3.SetActive(index == 2);
    }
}

