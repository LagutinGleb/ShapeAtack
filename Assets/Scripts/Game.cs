using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private int limitOfKilledFriends = 3;
    private int limitOfPassedEnemyes = 3;
    private int killedFriends;
    private int passedEnemyes;

    public Image[] enemyImages = new Image[3];
    public Image[] friendImages = new Image[3];


    private void Update()
    {
      
    }

    public void onFriendKilled()
    {
        killedFriends++;
        friendImages[killedFriends - 1].enabled = false;

        if (killedFriends == limitOfKilledFriends)
        {
            Debug.Log("Game over");
            Time.timeScale = 0;
        }
    }

    public void onEnemyPassed()
    {
        passedEnemyes++;
        enemyImages[passedEnemyes - 1].enabled = true;
        if (passedEnemyes == limitOfPassedEnemyes)
        {
            Debug.Log("Game over");
            Time.timeScale = 0;
        }
    }


    public static void TimeOff()
    {
        Debug.Log("Level Passed");
    }


}
