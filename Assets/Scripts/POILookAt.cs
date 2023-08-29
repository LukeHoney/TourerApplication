using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POILookAt : MonoBehaviour
{
    public Transform player; // Reference to what Points of Interest has to look at (player)

    // Update is called once per frame
    void Update()
    {
        Vector3 lookAtPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
        transform.LookAt(lookAtPosition);
        // Set the fixed X rotation to 90 degrees
        Vector3 currentRotation = transform.eulerAngles;
        transform.eulerAngles = new Vector3(90f, currentRotation.y, currentRotation.z);
    }

}



