using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public string levelToLoad;
    public GameObject settingsPanel;

    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void SettingsBtn()
    { 
        settingsPanel.SetActive(true);
    }
    public void CloseSettingsBtn()
    {
        settingsPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
}
