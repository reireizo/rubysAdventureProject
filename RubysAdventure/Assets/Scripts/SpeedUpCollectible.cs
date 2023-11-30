using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpCollectible : MonoBehaviour
{
    public GameObject pickupEffect;
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.isFaster != true)
            {
                controller.SpeedPickup();
                Instantiate(pickupEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
                controller.PlaySound(collectedClip);
            }
        }
    }
}
