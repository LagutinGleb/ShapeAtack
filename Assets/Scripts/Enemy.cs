using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Bullet bullet))
        {
            Destroy(gameObject);
            Destroy(bullet.gameObject);
        }
    }
}
