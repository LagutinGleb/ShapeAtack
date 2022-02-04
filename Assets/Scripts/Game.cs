using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private float LevelTime = 20;
    
    private const int limitOfKilledFriends = 3;
    private const int limitOfPassedEnemyes = 3;
    private int killedFriends;
    private int passedEnemyes;

    public Image[] enemyImages = new Image[3];
    public Image[] friendImages = new Image[3];
    public Text levelNumber;
    public GameObject fire;
    public GameObject canvasLose;
    public GameObject canvasWin;
    public GameObject UI;
    public Text TimerText;
    public Text SpeedX;
    public Text reasonOfLoose;

    AudioSource sound;
    public AudioClip enemyPassed;

    public static int levelCount;
    private Fire fireControl;

    private void Start() // пока открыто начальное меню - фризим игру, отключаем контроль над оружием, устанавливаем данные об уровне
    {
        Time.timeScale = 0;
        levelNumber.text = "Level " + (levelCount + 1);
        SpeedX.text = "Speed X " + (levelCount + 1);
        fireControl = fire.GetComponent<Fire>();
        fireControl.enabled = false;
        sound = GetComponent<AudioSource>();
    }

    void Update() //обратный таймер, если время вышло -  уровень пройден
    {
        if (LevelTime > 0)
        {
           LevelTime = LevelTime - Time.deltaTime;
           TimerText.text = LevelTime.ToString("0");
        }
        else
        Win(); 
    }

    public void onFriendKilled() //действия, если попали в друга, 
    {
        killedFriends++;
        Debug.Log(killedFriends);
        friendImages[killedFriends - 1].enabled = false;
        sound.Play();

        if (killedFriends == limitOfKilledFriends)
        {
            reasonOfLoose.text = "You killed 3 Friends :(";
            Lose(); 
        }
    }

    public void onEnemyPassed() // действия, если пропустили врага
    {
        passedEnemyes++;
        enemyImages[passedEnemyes - 1].enabled = true;
        sound.PlayOneShot(enemyPassed);

        if (passedEnemyes == limitOfPassedEnemyes)
            {
                reasonOfLoose.text = "3 enemies passed :(";
                Lose(); 
            }
    }

    private void Lose()
    {
        Debug.Log("Game over");
        Time.timeScale = 0;
        fireControl.enabled = false;
        canvasLose.SetActive(true);
    }

    private void Win()
    {
        Debug.Log("Win");
        Time.timeScale = 0;
        fireControl.enabled = false;
        canvasWin.SetActive(true);
    }
}
