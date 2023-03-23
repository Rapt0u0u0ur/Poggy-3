using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoveTest : MonoBehaviour
{
    public int playermoveX;
    public int playermoveY;
    public int speed;
    CamController camControl;

    // Start is called before the first frame update
    void Start()
    {
        camControl = Camera.main.GetComponent<CamController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        { 
            transform.position = new Vector2(transform.position.x + playermoveX, transform.position.y + playermoveY); 
        }
    }
}
