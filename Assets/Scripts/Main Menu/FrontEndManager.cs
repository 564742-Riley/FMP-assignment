using UnityEngine;
using UnityEngine.EventSystems;

public class FrontEndManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuCanvasGO;
    [SerializeField] private GameObject _quitCanvasGO;
    [SerializeField] private GameObject _audioCanvasGO;
    


    [SerializeField] private GameObject _mainMenuFirst;
    [SerializeField] private GameObject _audioMenuFirst;
    [SerializeField] private GameObject _quitMenuFirst;
   




    private bool ispaused;

    private void Start()
    {
        _audioCanvasGO.SetActive(false);
        _quitCanvasGO.SetActive(false);
        

    }

   

    public void OpenAudioMenuHandle()
    {
        _audioCanvasGO.SetActive(true);
        _quitCanvasGO.SetActive(false);
        _mainMenuCanvasGO.SetActive(false);
        


        EventSystem.current.SetSelectedGameObject(_audioMenuFirst);
    }


    private void OpenQuitMenu()
    {
        _audioCanvasGO.SetActive(false);
        _quitCanvasGO.SetActive(true);
        _mainMenuCanvasGO.SetActive(true);
        


        EventSystem.current.SetSelectedGameObject(_quitMenuFirst);
    }

    private void OpenMainMenu()
    {
        _mainMenuCanvasGO.SetActive(true);
        _audioCanvasGO.SetActive(false);
        _quitCanvasGO.SetActive(false);


        EventSystem.current.SetSelectedGameObject(_mainMenuFirst);
    }




    

    public void OnAudioPress()
    {
        OpenAudioMenuHandle();
    }

   

    public void OnAudioBackPress()
    {
        OpenMainMenu();
    }


    public void OnQuitPress()
    {
        OpenQuitMenu();
    }

    public void OnQuitBackPress()
    {
        OpenMainMenu();
    }






}
