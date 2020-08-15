using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //This script enables and disables the pause menu and controls what happens when the buttons on the menu are clicked.
    public GameObject pausePanel;
    private bool gamePaused;
    public GameObject mainPauseMenu;
    public GameObject rulesMenu;

    void Start()
    {
        pausePanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused == false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        gamePaused = true;
    }

    public void Resume()
    {
        rulesMenu.SetActive(false);
        mainPauseMenu.SetActive(true);

        pausePanel.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
    }

    public void Rules()
    {
        Debug.Log("Rules");
        mainPauseMenu.SetActive(false);
        rulesMenu.SetActive(true);
    }

    public void Back()
    {
        rulesMenu.SetActive(false);
        mainPauseMenu.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        SceneManager.LoadScene(0);
    }
}
