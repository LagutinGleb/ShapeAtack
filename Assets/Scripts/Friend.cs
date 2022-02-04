using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour
{
    private Game game;

    private void Start()
    {
            game = GameObject.Find("Game").GetComponent<Game>(); //на префаб нельзя повесить компонент GameObject со сцены, пришлось искать в ручную
    }

    private void OnCollisionEnter(Collision collision) //если стрельнул в друга, дестроим оба объекта и засчитываем штраф
    {
        if (collision.collider.TryGetComponent(out Bullet bullet))
        {
            Destroy(gameObject);
            Destroy(bullet.gameObject);
            game.onFriendKilled();
        }
    }
}
