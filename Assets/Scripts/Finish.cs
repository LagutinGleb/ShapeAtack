using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private Game game;

    private void Start()
    {
        game = GameObject.Find("Game").GetComponent<Game>(); //�� ������ ������ �������� ��������� GameObject �� �����, �������� ������ � ������
    }

    private void OnTriggerEnter(Collider other) //���� ���� ������ ������ Entmy, �������� �� ���� ����, � ���������� ������
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
         game.onEnemyPassed();
        }
        Destroy(other.gameObject);
    }
}
