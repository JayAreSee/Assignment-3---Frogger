﻿using UnityEngine;
using UnityEngine.SceneManagement;


public class FrogScript : MonoBehaviour
{

    public Rigidbody2D rb;
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            rb.MovePosition(rb.position + Vector2.right);

        else if (Input.GetKeyDown(KeyCode.A))
                rb.MovePosition(rb.position + Vector2.left);

        else if (Input.GetKeyDown(KeyCode.W))
            rb.MovePosition(rb.position + Vector2.up);

        else if (Input.GetKeyDown(KeyCode.S))
            rb.MovePosition(rb.position + Vector2.down);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Car")
        {
            Debug.Log("You LOST!");
            Score.CurrentScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
