using UnityEngine;

public class CameraStabilzer : MonoBehaviour
{
    public float carX;
    public float carY;
    public float carZ;
    public GameObject car;
    
    
    void Update()
    {
        carX = car.transform.eulerAngles.x;
        carY = car.transform.eulerAngles.y;
        carZ = car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);
    }
}