using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    bool isOpened = false;
    public float doorCooldown = 5;

    private void OnTriggerEnter(Collider col)
    {
        if (!isOpened)
        {
            isOpened = true;
            door.transform.position += new Vector3(0, -8, 0);
        }
    }
}
