using UnityEngine;

public class DontdestroyOnLoad : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
