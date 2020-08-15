using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void Quit()
    {
        //This controls the quit to main menu button
        Debug.Log("Quit");
        SceneManager.LoadScene(0);
    }
}
