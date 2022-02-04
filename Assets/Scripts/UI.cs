using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject canvasGame;
    public GameObject canvasStart;
    public GameObject fire;

    public void ButtonStart()
    {
        canvasStart.gameObject.SetActive(false);
        Time.timeScale = 1;
        fire.GetComponent<Fire>().enabled = true;
    }

    public void ButtonExit()
    {
        Application.Quit();
    }

    public void ButtonRestart()
    {
        SceneManager.LoadScene(0);
    }

    public void ButtonNext()
    {
        Game.levelCount++;
        SceneManager.LoadScene(0);
    }
}
