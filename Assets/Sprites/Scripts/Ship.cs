﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship : MonoBehaviour {

    Rigidbody2D rb;
    private float speed = 10f;
    public Text scoree;


    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {
        if (transform.position.y < 2.5 && transform.position.y > -2.5)
        {
            float movX = Input.acceleration.x;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);


        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //scoree.text = GameController.instance.score.ToString;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.gameOver = true;
    }

}
