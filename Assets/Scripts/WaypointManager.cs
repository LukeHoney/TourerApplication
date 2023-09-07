using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.XR.ARCoreExtensions;

public class WaypointManager : MonoBehaviour
{
    [Header("Routes")]
    public GameObject swanseaAreanWaypointParent; //Reference to the Swansea Arean Waypoint object
    public GameObject glynnVivianArtGalleryWaypointParent; //Reference to the Glynn Vivian Art Gallery Waypoint object
    public GameObject plantasiaTropicalWaypointParent;
    public GameObject grandTheatreWaypointParent;
    public GameObject swanseaMuseumWaypointParent;
    [Header("Other")]
    public Transform arrow; // Reference to the arrow GameObject
    public GameObject ReachDestinationPanel;
    public GameObject locationBanner;

    public AudioManager audioManager;

    public List<Transform> waypoints = new List<Transform>(); // List of all waypoints
    public int currentWaypointIndex = 0; // Index of the current waypoint

    private void Start()
    {
        arrow.gameObject.SetActive(false); // Disable the arrow initially
    }

    public void StartSwanseaArena()
    {
        // Enable the waypoints and their parent
        swanseaAreanWaypointParent.SetActive(true);
        ActivateAllChildren(swanseaAreanWaypointParent);
        //AREarthManager.CheckVpsAvailability;

        // Populate waypoints and enable the arrow
        PopulateWaypoints(swanseaAreanWaypointParent);
        arrow.gameObject.SetActive(true);
    }
    public void StartglynnVivianArtGallery()
    {
        // Enable the waypoints and their parent
        glynnVivianArtGalleryWaypointParent.SetActive(true);
        ActivateAllChildren(glynnVivianArtGalleryWaypointParent);

        // Populate waypoints and enable the arrow
        PopulateWaypoints(glynnVivianArtGalleryWaypointParent);
        arrow.gameObject.SetActive(true);
    }
    public void StartplantasiaTropical()
    {
        // Enable the waypoints and their parent
        plantasiaTropicalWaypointParent.SetActive(true);
        ActivateAllChildren(plantasiaTropicalWaypointParent);

        // Populate waypoints and enable the arrow
        PopulateWaypoints(plantasiaTropicalWaypointParent);
        arrow.gameObject.SetActive(true);
    }
    public void StartgrandTheatre()
    {
        // Enable the waypoints and their parent
        grandTheatreWaypointParent.SetActive(true);
        ActivateAllChildren(grandTheatreWaypointParent);

        // Populate waypoints and enable the arrow
        PopulateWaypoints(grandTheatreWaypointParent);
        arrow.gameObject.SetActive(true);
    }
    public void StartswanseaMuseum()
    {
        // Enable the waypoints and their parent
        swanseaMuseumWaypointParent.SetActive(true);
        ActivateAllChildren(swanseaMuseumWaypointParent);

        // Populate waypoints and enable the arrow
        PopulateWaypoints(swanseaMuseumWaypointParent);
        arrow.gameObject.SetActive(true);
    }


    private void ActivateAllChildren(GameObject parent)
    {
        foreach (Transform child in parent.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    private void PopulateWaypoints(GameObject waypointParent)
    {
        ClearWaypoints(); // Clear the existing waypoints list

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
        if (waypoints.Count > 0 && currentWaypointIndex < waypoints.Count)
        {
            Transform closestWaypoint = waypoints[currentWaypointIndex];
            float closestDistance = Vector3.Distance(arrow.position, closestWaypoint.position);

            for (int i = currentWaypointIndex + 1; i < waypoints.Count; i++)
            {
                float distanceToWaypoint = Vector3.Distance(arrow.position, waypoints[i].position);

                if (distanceToWaypoint < closestDistance)
                {
                    closestWaypoint = waypoints[i];
                    closestDistance = distanceToWaypoint;
                    currentWaypointIndex = i; // Update the current waypoint index to the closest waypoint
                }
            }

            // Remove waypoints before the closest one
            waypoints.RemoveRange(0, currentWaypointIndex);

            arrow.LookAt(closestWaypoint);
        }
        else
        {
            // All waypoints reached or no waypoints available, disable the arrow and activate ReachDestinationPanel
            audioManager.FinishAudio();
            ReachDestinationPanel.gameObject.SetActive(true);
            locationBanner.gameObject.SetActive(false);
            arrow.gameObject.SetActive(false);
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

    public void ClearWaypoints()
    {
        waypoints.Clear(); // Clear the existing waypoints list
        arrow.gameObject.SetActive(false);
    }

    public void SkipWaypoint()
    {
        if (currentWaypointIndex < waypoints.Count)
        {
            waypoints.RemoveAt(currentWaypointIndex);
            UpdateArrowTarget();
        }
    }
}
