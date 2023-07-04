using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform playerTransform;  // Reference to the player's transform
    public float minRotation = -15f;   // Minimum rotation limit in degrees
    public float maxRotation = 15f;    // Maximum rotation limit in degrees

    private Vector3 originalRotation;

    private void Start()
    {
        // Store the original rotation of the game object
        originalRotation = transform.eulerAngles;
    }

    private void LateUpdate()
    {
        // Get the direction from the game object to the player
        Vector3 direction = playerTransform.position - transform.position;

        // Calculate the desired rotation using LookRotation
        Quaternion desiredRotation = Quaternion.LookRotation(direction);

        // Extract the Euler angles from the desired rotation
        Vector3 desiredEuler = desiredRotation.eulerAngles;

        // Apply the rotation limits to the X and Y axes
        desiredEuler.x = ClampAngle(desiredEuler.x, originalRotation.x + minRotation, originalRotation.x + maxRotation);
        desiredEuler.y = ClampAngle(desiredEuler.y, originalRotation.y + minRotation, originalRotation.y + maxRotation);

        // Apply the modified rotation to the game object
        transform.rotation = Quaternion.Euler(desiredEuler);
    }

    private float ClampAngle(float angle, float min, float max)
    {
        // Wrap the angle to -180 to 180 degrees
        if (angle > 180f)
            angle -= 360f;

        // Clamp the angle between the minimum and maximum values
        return Mathf.Clamp(angle, min, max);
    }
}
