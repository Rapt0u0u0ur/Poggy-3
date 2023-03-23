using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public bool Right;
    public bool Up;
    public Vector3 newCamPos, newPlayerPos;

    CamController camControl;


    void Start()
    {
        camControl = Camera.main.GetComponent<CamController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
     //   if (gameObject.tag == "Player")
        {
          //  camControl.minPos += newCamPos;
          //  camControl.maxPos += newCamPos;

          //  transform.position += newPlayerPos;
        }


    }
}
