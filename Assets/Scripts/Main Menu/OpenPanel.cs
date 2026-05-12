using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OpenPanel : MonoBehaviour
{
    public GameObject panel;
    public Selectable firstButton;

    public void Open()
    {
        panel.SetActive(true);
        StartCoroutine(SelectFirstButton());
    }

    IEnumerator SelectFirstButton()
    {
        // Wait for UI to update
        yield return new WaitForEndOfFrame();

        firstButton.Select();
        EventSystem.current.SetSelectedGameObject(firstButton.gameObject);
    }
}