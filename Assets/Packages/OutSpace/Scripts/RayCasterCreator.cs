using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasterCreator : MonoBehaviour
{
    public string targetTag = "Planet"; // The tag of the target object
    public float raycastDistance = 100f; // Maximum raycast distance

    private int clickCount = 0; // Count of mouse clicks
    private float doubleClickTimeThreshold = 0.3f; // Time threshold for double click (adjust as needed)
    private float lastClickTime = 0f; // Time of the last mouse click

    public PlanetData PlanetData;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Calculate the time since the last click
            float timeSinceLastClick = Time.time - lastClickTime;

            if (timeSinceLastClick <= doubleClickTimeThreshold)
            {
                // Double click
                clickCount = 2;
            }
            else
            {
                // Single click
                clickCount = 1;
            }

            lastClickTime = Time.time;

            // Create a 2D ray starting from the GameObject's position and going right (adjust as needed)
            Vector2 rayDirection = transform.right;

            RaycastHit2D hit = Physics2D.Raycast(transform.position, rayDirection, raycastDistance);

            // Check if the ray hit something and if that something has the specified tag
            if (hit.collider != null && hit.collider.CompareTag(targetTag))
            {
                // Perform different actions based on the click count
                if (clickCount == 1)
                {
                    Debug.Log(hit.collider.gameObject.transform.parent.parent.name);
                    Debug.Log("Hello"); // Single click action
                }
                else if (clickCount == 2)
                {
                    Debug.Log("Hello2"); // Double click action
                }
            }
        }
    }
}
