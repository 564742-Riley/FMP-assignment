using UnityEngine;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{
    public Button primaryButton;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        primaryButton.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
