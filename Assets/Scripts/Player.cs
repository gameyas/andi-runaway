using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Xincrement;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;
    public float maxCorner;
    public float minCorner;

    public int health = 3;


    void Start()
    {
        targetPos = new Vector2(0.0f, -2.5f);

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minCorner)
        {
            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxCorner) 
        {
            targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }

    }
}
