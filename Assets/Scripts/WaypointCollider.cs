using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointCollider : MonoBehaviour
{
    private WaypointManager manager;
    public AudioManager audioManager;

    private void Start()
    {
        manager = FindObjectOfType<WaypointManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioManager.CheckpointAudio();
            manager.WaypointReached(transform);
            gameObject.SetActive(false); // Disable the collider instead of destroying the waypoint object
        }
    }
}
