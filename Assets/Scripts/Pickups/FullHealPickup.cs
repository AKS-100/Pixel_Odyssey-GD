using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FullHealPickUp : MonoBehaviour
{
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();

            if (playerHealth != null)
            {
                playerHealth.ReceiveHealing(playerHealth.maximumHealth);
            }

            Destroy(this.gameObject);
        }
    }
}