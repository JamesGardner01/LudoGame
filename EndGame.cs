using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit");
        SceneManager.LoadScene(0);
    }
}
