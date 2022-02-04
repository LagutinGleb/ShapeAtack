using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject canvasGame;
    public GameObject canvasStart;
    public GameObject fire;
    public Image[] enemyImages = new Image[3];

    public void ButtonStart()
    {
        canvasStart.gameObject.SetActive(false);
        Time.timeScale = 1;
        fire.GetComponent<Fire>().enabled = true;

        for (int i = 0; i < enemyImages.Length; i++)
        {
            enemyImages[i].enabled = false;
        }
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
