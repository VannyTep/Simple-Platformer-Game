using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningSpikeController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            SpikeTrapBehavior spikeTrapBehavior = FindObjectOfType<SpikeTrapBehavior>();
            spikeTrapBehavior.Dead();
        }
    }
}
