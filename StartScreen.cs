using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    //This script controls all of the buttons on the main menu, loads the game and quits the application
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
