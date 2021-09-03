using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop_Move : MonoBehaviour
{
    public GameObject wall;

    Vector3 propPosition;

    float wallWidth;

    bool isPropMoving;
    public bool posXDirection;
    public bool negXDirection;
    public bool posZDirection;
    public bool negZDirection;

    float timer;
    float timerReset = 5;

    // Start is called before the first frame update
    void Start()
    {
        propPosition = this.gameObject.transform.position;
        isPropMoving = false;
        timer = timerReset;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPropMoving)
        {
            timer -= 1 * Time.deltaTime;

            if (timer <= 0)
            {
                isPropMoving = false;
                timer = timerReset;
            }

            if (posXDirection)
            {
                wallWidth = wall.GetComponent<Collider>().bounds.extents.x;
                //this.gameObject.transform.position = wall.transform.position + new Vector3(wallWidth, prop.transform.position.y, prop.transform.position.z);
            }

            if (negXDirection)
            {
                wallWidth = wall.GetComponent<Collider>().bounds.extents.x;
                //this.gameObject.transform.position = wall.transform.position + new Vector3(-wallWidth, prop.transform.position.y, prop.transform.position.z);
            }

            if (posZDirection)
            {
                wallWidth = wall.GetComponent<Collider>().bounds.extents.z;
                //this.gameObject.transform.position = wall.transform.position + new Vector3(prop.transform.position.x, prop.transform.position.y, wallWidth);
            }

            if (negZDirection)
            {
                wallWidth = wall.GetComponent<Collider>().bounds.extents.z;
                this.gameObject.transform.position = propPosition + new Vector3(0, 0, -wallWidth);
            }

        }
    }

    public void StartPropMove()
    {
        isPropMoving = true;
    }
}
