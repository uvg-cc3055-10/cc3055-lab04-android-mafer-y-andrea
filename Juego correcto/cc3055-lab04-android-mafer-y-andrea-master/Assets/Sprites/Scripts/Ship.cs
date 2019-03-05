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
    private Vector2 startTouchPosition, endTouchPosition;
    Rigidbody2D rb;
    private float force = 700f;
    private bool jump = false;
    private float speed = 10f;
    

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        rb = GetComponent<Rigidbody2D>();

		
	}

    // Update is called once per frame
    void Update() {
        if (GameController.instance.gameOver == false)
        {

                //Mientras no haya perdido, aun se mueve la nave
                speed = 10f;
                float movY = Input.acceleration.x;
                rb.transform.Translate(Vector2.right * speed * movY * Time.deltaTime);
                SwipeCheck();
                Allowed();

        }
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si choca con un collider que esta triggered, pierde
        GameController.instance.gameOver = true;
    }

    private void SwipeCheck()
    {
        //se tienen que guardar las posiciones iniciales y finales del touch
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            endTouchPosition = Input.GetTouch(0).position;
        
      
        if (endTouchPosition.y > startTouchPosition.y && rb.velocity.y == 0)
            jump = true;
    }

    private void Allowed()
    {
        if (jump)
        {
            rb.AddForce(Vector2.up * force);
            jump = false;
        }
    }
}
