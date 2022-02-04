using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private Game game;

    private void Start()
    {
        game = GameObject.Find("Game").GetComponent<Game>(); //на префаб нельзя повесить компонент GameObject со сцены, пришлось искать в ручную
    }

    private void OnTriggerEnter(Collider other) //если мимо игрока прошел Entmy, сообщаем об этом игре, и уничтожаем объект
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
         game.onEnemyPassed();
        }
        Destroy(other.gameObject);
    }
}
