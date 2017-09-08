using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : BallBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "BlueBucket")
        {
            Destroy(gameObject);
        }

        if (col.tag == "RedBucket")
        {
            Destroy(gameObject);
        }
    }
}
