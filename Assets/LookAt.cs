using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public List<Transform> waypoints;  // Reference to the list of waypoints
    public float reachedDistance = 10f; // Threshold distance to consider a waypoint as reached
    private int currentWaypointIndex = 0; // Index of the current waypoint

    void Update()
    {
        if (waypoints.Count == 0)
            return;  // No waypoints, so nothing to do

        // Check if the player has reached the current waypoint
        float distance = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);
        if (distance <= reachedDistance)
        {
            // Remove the current waypoint from the list
            waypoints.RemoveAt(currentWaypointIndex);

            // Update the current waypoint index
            if (currentWaypointIndex >= waypoints.Count)
                currentWaypointIndex = 0;
        }

        // Make the arrow look at the current waypoint
        transform.LookAt(waypoints[currentWaypointIndex]);
    }
}
