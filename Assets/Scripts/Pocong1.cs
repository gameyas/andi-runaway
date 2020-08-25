using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocong1 : MonoBehaviour
{

    private Vector2 targetPos;
    public float[] XPosition;
    public int damage = 1;
    public float speed;
    int rand;
    private void Start()
    {
        rand = Random.Range(0, XPosition.Length);
    }

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        

        if (transform.position.y < 2)
        {
            targetPos = new Vector2(XPosition[rand], transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}
