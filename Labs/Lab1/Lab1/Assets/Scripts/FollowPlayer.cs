using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Create a variable to hold a reference to the player game object
    public GameObject player;

    // Create a variable to offset the camera from the player
    private Vector3 offset = new Vector3(0, 6, -7);

    // Start is called before the first frame update
    void Start()
    {

    }

    // LateUpdate is called after Update()
    void LateUpdate()
    {
        // Set the camera's position to the player's position plus the offset amount
        transform.position = player.transform.position + offset;
    }
}
