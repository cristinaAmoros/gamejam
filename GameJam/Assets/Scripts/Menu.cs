using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("Inici");
    }

    public void start()
    {
        SceneManager.LoadScene("historia");
    }
    public void part2()
    {
        SceneManager.LoadScene("historia1");
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
        SceneManager.LoadScene("nivell1");
    }
    public void comença()
    {
        SceneManager.LoadScene("nivell1");
    }
    public void nivell_final()
    {
        SceneManager.LoadScene("nivell_fi");
    }
}
