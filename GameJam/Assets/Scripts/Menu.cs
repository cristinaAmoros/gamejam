using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("nivell_1");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void next()
    {
        SceneManager.LoadScene("Final");
    }

    public void retorna()
    {
        SceneManager.LoadScene("nivell_1");
    }
}
