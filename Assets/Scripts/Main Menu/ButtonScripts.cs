using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public TMP_Text buttonText;




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

    
       
}


