using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{

    public int score;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle") || other.CompareTag("Pocong 1"))
        {
            score++;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}
