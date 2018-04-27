/*
 * HighScore.cs
 * Guarda el highscore en su respectivo cuadro de texto
 * Andrea Arguello 17801, Maria Fernanda Lopez 17160
 * 27/04/2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    //Atributos
    public Text hs;

	// Carga el highscore cada vez que se inicializa
	void Start () {

        hs.text = PlayerPrefs.GetFloat("HighScore").ToString("F0");
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
