using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public AudioSource Fanfare;

    public void Start()
    {
        Fanfare.Play();
    }

    public void PlayAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
