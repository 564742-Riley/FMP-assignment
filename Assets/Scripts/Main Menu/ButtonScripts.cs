using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public TMP_Text buttonText;

   


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Click Detected");
        }
    }



    public void BackLevelSelect()
    {
        buttonText.text = "x";
        SceneManager.LoadScene("LevelSelect");

    }
    
    public void PlayButton()
    {
        buttonText.text = "Loading...";
        SceneManager.LoadScene("LevelSelect");

    }

    public void QuitButton()
    {

        SceneManager.LoadScene("FrontEnd");

    }

    public void Track()
    {
 
        SceneManager.LoadScene("Track");
        Debug.Log("button pressed");

    }
    
    public void QuitGame()
    {
        Application.Quit();
    }


    public void PlaySFX()
    {
       // AudioManager.instance.Play("SFX");
    }

    public void MusicMute(bool mute)
    {
        //AudioManager.instance.musicMute = mute;
    }

    
        public void Test()
        {
            Debug.Log("BUTTON WORKS");
        }
}


