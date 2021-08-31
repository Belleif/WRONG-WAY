using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Lerp : MonoBehaviour
{
    public GameObject[] walls;                               // Array of all the walls to be changed

    private bool shouldLerp = false;
    private bool timer = false;

    private float timeStartedLerping;
    public float lerpTime;                                   // Use to change the speed at which the walls change

    private float growTime;                                  // Used as timer to stop lerp
    public float resetGrowTime;                              // Used to reset growTime back to user specified value

    public float wallGrowth;                                 // Used to grow the walls by an amount specified by user

    // Start is called before the first frame update
    void Start()
    {
        StartLerping();
        walls = GameObject.FindGameObjectsWithTag("wall");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            shouldLerp = true;
            timer = true;
        }
        if (timer)
        {
            growTime -= 1 * Time.deltaTime;

            if (growTime <= 0)
            {
                shouldLerp = false;
                timer = false;
                growTime = resetGrowTime;
            }
        }
    }

    private void FixedUpdate()
    {
        if (shouldLerp)
        {
            foreach (GameObject r in walls)
            {
                r.transform.localScale = Lerp(r.transform.localScale, r.transform.localScale + new Vector3(wallGrowth, 0, wallGrowth), timeStartedLerping, lerpTime);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            shouldLerp = true;
            timer = true;
        }
    }

    private void StartLerping()
    {
        timeStartedLerping = Time.time;
    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;

        float percentageComplete = timeSinceStarted / lerpTime;

        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
}
