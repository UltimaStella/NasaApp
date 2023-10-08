using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasterCreator : MonoBehaviour
{
    public string targetTag = "Planet"; // The tag of the target object
    public float raycastDistance = 100f; // Maximum raycast distance

    public bool OnPlanetHighLight = false;
    void Update()
    {
        Vector2 rayDirection = transform.right; // You can adjust the direction as needed

        RaycastHit2D hit = Physics2D.Raycast(transform.position, rayDirection, raycastDistance);
        
        // Check if the ray hit something and if that something has the specified tag
        if (hit.collider != null && hit.collider.CompareTag(targetTag))
        {
            // The ray hit an object with the "planet" tag
          //  Debug.Log("Hello");
        }
    }
}
