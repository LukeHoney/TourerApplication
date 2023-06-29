using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public List<Transform> waypoints; // List of all waypoints
    public Transform arrow; // Reference to the arrow GameObject

    public int currentWaypointIndex = 0; // Index of the current waypoint

    private void Start()
    {
        if (waypoints.Count > 0)
        {
            // Set the arrow's initial target to the first waypoint
            arrow.LookAt(waypoints[currentWaypointIndex]);
        }
        else
        {
            // No waypoints available, disable the arrow
            arrow.gameObject.SetActive(false);
        }
    }

    private void UpdateArrowTarget()
    {
        if (currentWaypointIndex >= waypoints.Count)
        {
            // All waypoints reached, disable the arrow
            arrow.gameObject.SetActive(false);
        }
        else
        {
            // Set the arrow's target to the current waypoint
            arrow.LookAt(waypoints[currentWaypointIndex]);
        }
    }

    public void WaypointReached(Transform waypoint)
    {
        // Check if there are remaining waypoints
        if (currentWaypointIndex < waypoints.Count)
        {
            // Remove the reached waypoint from the list
            waypoints.Remove(waypoint);

            // Update the arrow's target
            UpdateArrowTarget();
        }
    }
}

