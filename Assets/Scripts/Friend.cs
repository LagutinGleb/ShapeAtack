using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour
{
    private Game game;

    private void Start()
    {
            game = GameObject.Find("Game").GetComponent<Game>(); //�� ������ ������ �������� ��������� GameObject �� �����, �������� ������ � ������
    }

    private void OnCollisionEnter(Collision collision) //���� ��������� � �����, �������� ��� ������� � ����������� �����
    {
        if (collision.collider.TryGetComponent(out Bullet bullet))
        {
            Destroy(gameObject);
            Destroy(bullet.gameObject);
            game.onFriendKilled();
        }
    }
}
