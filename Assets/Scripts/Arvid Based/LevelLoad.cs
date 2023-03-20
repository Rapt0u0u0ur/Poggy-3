using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoad : MonoBehaviour
{

    public Transform player;
    public float smoothspeed;

    private Vector3 targetspot, newspot;

    public Vector3 minspot, maxspot;


    void LateUpdate()
    {
        if (transform.position != player.position)
        {
            targetspot = player.position;

            Vector3 camBoundaryPos = new Vector3(
                Mathf.Clamp(targetspot.x, minspot.x, maxspot.x),
                Mathf.Clamp(targetspot.y, minspot.y, maxspot.y),
                Mathf.Clamp(targetspot.z, minspot.z, maxspot.z));

            newspot = Vector3.Lerp(transform.position, camBoundaryPos, smoothspeed);
            transform.position = newspot;
        }
    }

}
