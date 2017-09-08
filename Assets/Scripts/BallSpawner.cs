using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{

    public class BallSpawner : MonoBehaviour
    {
        public GameObject[] ballPrefabs;        
        public float spawnAmount = 10f;
        public float spawnTimer = 1f;
        public float spawnRate = 1f;



        // Use this for initialization
        void Start()
        {
            // call Spawn so it spawn a new prefab every spawnRate seconds
            InvokeRepeating("Spawn", 0, spawnRate);
        }
        
        void Spawn()
        {
            // LET clone = new instance of ballPrefabs[], which chooses a prefab to spawn at random
            GameObject clone = Instantiate(ballPrefabs[Random.Range(0, ballPrefabs.Length)]);
            clone.transform.position = transform.position;

        }
    }
}
