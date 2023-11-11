using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject settingsPanel;
    public AudioSource audioSource;
    public AudioSource sound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void SettingsBtn()
    {
        settingsPanel.SetActive(true);
    }
    public void CloseSettingsBtn()
    {
        settingsPanel.SetActive(false);
    }

    void Paused()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale =  1;
        gameIsPaused = false;
    }

    public void MainMenu()
    {
        Resume();
        SceneManager.LoadScene("Menu");
    }

    public void PlaySound()
    {
        sound.Play();
    }
}
