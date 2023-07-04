using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public GameObject clockwiseWaypointParent; // Reference to the clockwise waypoints parent object
    public GameObject counterclockwiseWaypointParent; // Reference to the counterclockwise waypoints parent object
    public GameObject shortCutWaypointParent; // Reference to the counterclockwise waypoints parent object
    public Transform arrow; // Reference to the arrow GameObject

    public List<Transform> waypoints = new List<Transform>(); // List of all waypoints
    public int currentWaypointIndex = 0; // Index of the current waypoint

    private void Start()
    {
        arrow.gameObject.SetActive(false); // Disable the arrow initially
    }

    public void StartClockwise()
    {
        clockwiseWaypointParent.SetActive(true); // Enable the waypoints
        PopulateWaypoints(clockwiseWaypointParent);
        arrow.gameObject.SetActive(true); // Enable the arrow
    }

    public void StartCounterclockwise()
    {
        counterclockwiseWaypointParent.SetActive(true); // Enable the waypoints
        PopulateWaypoints(counterclockwiseWaypointParent);
        arrow.gameObject.SetActive(true); // Enable the arrow
    }

    public void StartshortCut()
    {
        shortCutWaypointParent.SetActive(true); // Enable the waypoints
        PopulateWaypoints(shortCutWaypointParent);
        arrow.gameObject.SetActive(true); // Enable the arrow
    }

    private void PopulateWaypoints(GameObject waypointParent)
    {
        waypoints.Clear(); // Clear the existing waypoints list

        if (waypointParent != null)
        {
            // Get all child transforms of the selected parent object and add them to the waypoints list
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

