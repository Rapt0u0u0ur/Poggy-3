using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{

    public Vector3 newCamSpot, newPlayerSpot;

    LevelLoad camControl;


    void Start()
    {
        camControl = Camera.main.GetComponent<LevelLoad>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            camControl.minspot += newCamSpot;
            camControl.maxspot += newCamSpot;

            other.transform.position += newPlayerSpot;
        }
        
    }
}
