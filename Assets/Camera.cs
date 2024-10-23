using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset; // Offset distance between the player and camera

    // Update is called once per frame
    void Update()
    {
        // Set the position of the camera to the player's position with the offset
        transform.position = player.position + offset;
    }
}
