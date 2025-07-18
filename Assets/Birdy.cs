using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    private Rigidbody2D rb;
    public GameManager managerGame;
    public GameObject DeadScreen;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Coin")
        {
            managerGame.UpdateScore();
        }
        if (collision.gameObject.name == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeadScreen.SetActive(true);
        }
    }
}
