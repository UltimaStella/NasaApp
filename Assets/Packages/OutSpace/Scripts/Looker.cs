using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Looker : MonoBehaviour
{

    public Transform Target; // Reference to the target object (GameObject B)
 

    public void Update()
    {
        if (Target != null)
        {
            transform.LookAt(Target);
        }
    }
}
