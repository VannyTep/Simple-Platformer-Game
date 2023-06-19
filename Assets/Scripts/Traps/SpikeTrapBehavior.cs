using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SpikeTrapBehavior : MonoBehaviour
{
    [SerializeField] GameObject RestartUI;

    public void Dead()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        GameObject FollowedCamera = GameObject.FindGameObjectWithTag("MainCamera");

        FollowedCamera.GetComponent<CinemachineVirtualCamera>().enabled = false;
        Player.GetComponent<BoxCollider2D>().isTrigger = true;

        RestartUI.SetActive(true);

        Debug.Log("Player is Dead");
    }
}
