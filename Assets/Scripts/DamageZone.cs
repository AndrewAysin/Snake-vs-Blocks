using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public int DamageWall = 100;
    private void OnTriggerStay(Collider other)
    {
        Health Wall = other.GetComponent<Health>();
        if (Wall == null) return;
        Wall.StartHelthpoint -= DamageWall;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            PlayerManager.isGameOver = true;
        }

    }
}
