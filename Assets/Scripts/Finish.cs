using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private Game game;

    private void Start()
    {
        game = GameObject.Find("Game").GetComponent<Game>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
         game.onEnemyPassed();
        }
        Destroy(other.gameObject);
    }
}
