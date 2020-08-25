using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    public float delayTimer = 2f;
    float timer;

    private void Start()
    {
        timer = delayTimer;
    }

    private void Update()
    {

        timer -= Time.deltaTime;

        if (timer <= 0) {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);

            timer = delayTimer;
        }
    }
}
