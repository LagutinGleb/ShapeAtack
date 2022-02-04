using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotGenerator : MonoBehaviour
{
    public GameObject[] EnemyPrefabs = new GameObject[3];
    public GameObject[] FriendPrefabs = new GameObject[3];
    public float BotVelocity;
    public GameObject game;

        private void Start() // генерируем новых ботов с задержкой по времени
        {
            InvokeRepeating("CreateBot", 0f, 2f);
        }

        void CreateBot() // генерация ботов из префабов в рандомную позицию (одна из четырех линий), вид бота генерируется рандомно (хороший плохой, и его скин), задаем боту направление движения
        {
            int rnd = Random.Range(1,3);
            GameObject bot;

            if (rnd == 1)
                {
                 bot = Instantiate(EnemyPrefabs[Random.Range(0,3)], transform.position - new Vector3(RandomiserOfPositon(), 0,0), Quaternion.identity);
                }
            else 
                 bot = Instantiate(FriendPrefabs[Random.Range(0, 3)], transform.position - new Vector3(RandomiserOfPositon(), 0, 0), Quaternion.identity);

            bot.GetComponent<Rigidbody>().velocity = -transform.forward * BotVelocity * (Game.levelCount + 1);
        }
    
        private int RandomiserOfPositon()
        {
            int positionX = 1;
            int rnd = Random.Range(1, 5);

            if (rnd == 1)
                positionX = -3;
            else if (rnd == 2)
                positionX = -1;
            else if (rnd == 3)
                positionX = 1;
            else if (rnd == 4)
                positionX = 3;

            return positionX;
        }
}
