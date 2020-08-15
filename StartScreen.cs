using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject ruleScreen;


    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void RuleButton()
    {
        mainMenu.SetActive(false);
        ruleScreen.SetActive(true);
    }

    public void BackButton()
    {
        ruleScreen.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
