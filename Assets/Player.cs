using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 5f;
    public SloMoManager sloMoManager;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {   
        //player movement
        float x = Input.GetAxis("Horizontal") * Time.fixedUnscaledDeltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            sloMoManager.SlowCar();     
        }
    }

    void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
