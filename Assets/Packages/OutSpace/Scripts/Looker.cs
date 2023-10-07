using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{

    public Transform Target; // Reference to the target object (GameObject B)

    public void Update()
    {
        if (Target != null)
        {
            // Calculate the rotation needed to look at the target
            var lookDirection = Target.position - transform.position;
            var rotation = Quaternion.LookRotation(lookDirection);
            
            // Apply the rotation to GameObject A
            transform.rotation = rotation;
        }
    }
}
