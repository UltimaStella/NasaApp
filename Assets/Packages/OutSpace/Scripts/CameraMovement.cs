using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target; // Reference to the GameObject's Transform that the camera will follow
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Offset to control the camera's position relative to the target
    public float smoothSpeed = 5f; // Speed at which the camera follows the target

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position for the camera
            Vector3 desiredPosition = target.position + offset;

            // Smoothly interpolate between the current camera position and the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            // Set the camera's position to the smoothed position
            transform.position = smoothedPosition;

            // Make the camera look at the target GameObject
            transform.LookAt(target);
        }
    }
}
