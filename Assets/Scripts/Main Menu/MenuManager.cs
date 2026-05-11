using UnityEngine;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuCanvasGO;
    [SerializeField] private GameObject _settingsCanvasGO;
    [SerializeField] private GameObject _controlCanvasGO;
   


    [SerializeField] private GameObject _mainMenuFirst;
    [SerializeField] private GameObject _settingsMenuFirst;
    [SerializeField] private GameObject _controlMenuFirst;
   
   
    
    private bool ispaused;

    private void Start()
    {
        _mainMenuCanvasGO.SetActive(false);
        _settingsCanvasGO.SetActive(false);
        _controlCanvasGO.SetActive(false);
    }

    private void Update()
    {
        if (InputManager.instance.MenuOpenCloseInput)
        {
            if (!ispaused)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        
        }  
    }


    public void Pause()
    {
        ispaused = true;
        Time.timeScale = 0f;

        OpenMainMenu();
    }


    public void Unpause()
    {
        ispaused =false;
        Time.timeScale = 1f;

        CloseAllMenus();
    }

    public void OpenSettingsMenuHandle()
    {
        _mainMenuCanvasGO.SetActive(false);
        _settingsCanvasGO.SetActive(true);
        _controlCanvasGO.SetActive(false);

        EventSystem.current.SetSelectedGameObject(_settingsMenuFirst);
    }


    private void OpenMainMenu()
    {
        _mainMenuCanvasGO.SetActive(true);
        _settingsCanvasGO.SetActive(false);
        _controlCanvasGO.SetActive(false);

        EventSystem.current.SetSelectedGameObject(_mainMenuFirst);
    }

    private void OpenControlMenu()
    {
        _mainMenuCanvasGO.SetActive(false);
        _settingsCanvasGO.SetActive(false);
        _controlCanvasGO.SetActive(true);

        EventSystem.current.SetSelectedGameObject(_controlMenuFirst);
    }


    private void CloseAllMenus()
    {
        _mainMenuCanvasGO.SetActive(false);
        _settingsCanvasGO.SetActive(false);
        _controlCanvasGO.SetActive(false);
        

        EventSystem.current.SetSelectedGameObject(null);
    }

    public void OnSettingsPress()
    {
        OpenSettingsMenuHandle();
    }

    public void OnResumePress()
    {
        Unpause();
    }


    public void OnSettingBackPress()
    {
        OpenMainMenu();
    }


    public void OncontrolPress()
    {
        OpenControlMenu();
    }

    public void OnControlsBackPress()
    {
        OpenSettingsMenuHandle();
    }

}
