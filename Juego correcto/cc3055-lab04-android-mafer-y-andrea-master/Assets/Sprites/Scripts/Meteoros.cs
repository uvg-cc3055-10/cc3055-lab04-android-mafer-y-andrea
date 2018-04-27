/*
 * Meteoros.cs
 * Controla la velocidad a la que salen los meteoritos
 * Andrea Arguello 17801, Maria Fernanda Lopez 17160
 * 27/04/2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoros : MonoBehaviour {
    //Atributos
    private float scrollingSpeed = 8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Se dezplaza hacia abajo con el pasar del tiempo
        transform.Translate(Vector3.down * scrollingSpeed * Time.deltaTime);
        if (transform.position.y < -8)
        {
            //Destruye si ya se pasa de cierta posicion
            Destroy(gameObject);
        }

        
        
    }
}
