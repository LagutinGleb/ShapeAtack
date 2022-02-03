using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float BotVelocity;

    private void Start()
    {
        InvokeRepeating("CreateBot", 0f, 2f);
    }

    void Update()
    {
        
    }

    void CreateBot()
    {
       GameObject Enemy = Instantiate(EnemyPrefab, transform.position - new Vector3(RandomiserOfPositon(), 0,0), Quaternion.identity);
       Enemy.GetComponent<Rigidbody>().velocity = -transform.forward * BotVelocity;
    }

    
    private int RandomiserOfPositon()
    {
    int positionX = 1;
    int rnd = Random.Range(1, 5);

        if (rnd == 1)
        {
            positionX = -3;
        }
        else if (rnd == 2)
        {
            positionX = -1;
        }
        else if (rnd == 3)
        {
            positionX = 1;
        }
        else if (rnd == 4)
        {
            positionX = 3;
        }

        return positionX;
    }
}
