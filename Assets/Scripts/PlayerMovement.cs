using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves and rotates Player
/// </summary>

public class PlayerMovement : MonoBehaviour
{
    
    public void LookAt(Vector3 point)
    {

        transform.LookAt(point);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

    }
}