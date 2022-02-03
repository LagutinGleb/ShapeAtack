using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private static int limitOfKilledFriends = 3;
    private static int limitOfPassedEnemyes = 3;
    public static int killedFriends;
    public static int passedEnemyes;


    private void Update()
    {
        //if (killedFriends == limitOfKilledFriends)
        //{
        //    Debug.Log("Game over");
        //}
    }




    public static void onFriendKilled()
    {
        killedFriends++;
        if (killedFriends == limitOfKilledFriends)
        {
            Debug.Log("Game over");
        }
    }

    public static void onEnemyPassed()
    {
        passedEnemyes++;
        if (passedEnemyes == limitOfPassedEnemyes)
        {
            Debug.Log("Game over");
        }
    }



}
