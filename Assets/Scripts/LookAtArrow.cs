using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtArrow : MonoBehaviour
{
    private WaypointManager manager;

    private void Start()
    {
        manager = FindObjectOfType<WaypointManager>();
    }

    private void Update()
    {
        if (manager.waypoints.Count > 0)
        {
            // Continuously update the arrow's look target
            transform.LookAt(manager.waypoints[manager.currentWaypointIndex]);
        }
    }
}
