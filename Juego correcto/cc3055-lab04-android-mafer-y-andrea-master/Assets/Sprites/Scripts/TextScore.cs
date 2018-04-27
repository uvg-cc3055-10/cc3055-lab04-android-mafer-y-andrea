/*
 * TextScore.cs
 * Carga el puntaje al cuadro de texto en el juego
 * Andrea Arguello 17801, Maria Fernanda Lopez 17160
 * 27/04/2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScore : MonoBehaviour {
    //Atributos
    public Text scoree;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Carga el puntaje actual en su respectivo cuadro de texto dentro de la escena
        scoree.text = (GameController.instance.score.ToString("F0"));
		
	}
}
