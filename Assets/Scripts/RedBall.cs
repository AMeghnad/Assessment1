using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : BallBehaviour {

	void OnTriggerEnter (Collider col)
    {
        if (col.tag == "RedBucket")
        {
            Destroy(gameObject);
        }

        if (col.tag == "BlueBucket")
        {
            Destroy(gameObject);
        }
    }
}
