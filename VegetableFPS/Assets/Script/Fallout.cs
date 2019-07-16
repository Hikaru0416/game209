using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallout : MonoBehaviour
{
    public Transform respawn;
    public Transform fallout;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == fallout)
        {
            transform.position = respawn.position;
        }
    }
}
