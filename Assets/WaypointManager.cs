using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public GameObject waypointParent; // Reference to the parent object containing the waypoints
    public Transform arrow; // Reference to the arrow GameObject

    public List<Transform> waypoints = new List<Transform>(); // List of all waypoints
    public int currentWaypointIndex = 0; // Index of the current waypoint

    private void Start()
    {
        if (waypointParent != null)
        {
            // Get all child transforms of the parent object and add them to the waypoints list
            foreach (Transform child in waypointParent.transform)
            {
                waypoints.Add(child);
            }

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
        // Check if the waypoint exists in the list
        if (waypoints.Contains(waypoint))
        {
            // Remove the reached waypoint from the list
            waypoints.Remove(waypoint);

            // Update the arrow's target
            UpdateArrowTarget();
        }
    }
}

