using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_motor_function : MonoBehaviour
{
    Vector3 Goal_2;
    Vector3 Goal;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Goal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == Goal)
        {
            Goal = Goal_2;
        }
        transform.position = Vector3.MoveTowards(transform.position, Goal, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift))
        {

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ActionDecider(1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ActionDecider(-1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            ActionDecider(0, -1);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ActionDecider(0, 1);
        }
    }
    void ActionDecider(int y, int x)
    {
        if (transform.position != Goal)
        {
            Goal_2 = Goal + new Vector3(x, y, 0);
        }
        else
        {
            Goal += new Vector3(x, y, 0);
            Goal_2 = Goal;
        }
    }
}
