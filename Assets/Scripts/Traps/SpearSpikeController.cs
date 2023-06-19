using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearSpikeController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") && SpearSpikeDetection.IsAttack == true)
        {
            SpikeTrapBehavior spikeTrapBehavior = FindObjectOfType<SpikeTrapBehavior>();
            spikeTrapBehavior.Dead();
        }
    }
}
