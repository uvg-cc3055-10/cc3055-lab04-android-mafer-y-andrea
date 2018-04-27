/*
 * GameController.cs
 * Controla acciones dentro del juego
 * Andrea Arguello 17801, Maria Fernanda Lopez 17160
 * 27/04/2018
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    //Atributos
    public Boolean gameOver = false;
    public float score = 0;
    public static GameController instance;

    // Use this for initialization
    void Start () {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameOver == false)
        {
            //Va sumandole al score en base al tiempo
            score += (Time.deltaTime);

        }
        if (gameOver == true)
        {
            //Si pierde, regresa al menu
            SceneManager.LoadScene("Menu");
        }
        if (score > PlayerPrefs.GetFloat("HighScore"))
        {
            //Carga el puntaje en highscore si es mayor al highscore anterior
            PlayerPrefs.SetFloat("HighScore", score);
        }

    }
}
