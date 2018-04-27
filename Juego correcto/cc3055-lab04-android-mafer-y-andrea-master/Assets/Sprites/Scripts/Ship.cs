/*
 * Ship.cs
 * Acciones de la nave
 * Andrea Arguello 17801, Maria Fernanda Lopez 17160
 * 27/04/2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {
    //Atributos
    Rigidbody2D rb;
    private float speed = 10f;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		
	}

    // Update is called once per frame
    void Update() {
        if (GameController.instance.gameOver == false)
        {
                //Mientras no haya perdido, aun se mueve la nave
                speed = 10f;
                float movX = Input.acceleration.x;
                rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
       
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si choca con un collider que esta triggered, pierde
        GameController.instance.gameOver = true;
    }
}
