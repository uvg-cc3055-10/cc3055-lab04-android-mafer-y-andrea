/*
 * Button.cs
 * Accion del boton del menu principal
 * Andrea Arguello 17801, Maria Fernanda Lopez 17160
 * 27/04/2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {
    //Atributos
    AudioSource newAudio;

    // Use this for initialization
    void Start () {
        newAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Change()
    {
        //Carga la nueva escena al presionar el boton
        SceneManager.LoadScene("Scene1");
        newAudio.Play();
        if(GameObject.FindGameObjectsWithTag("GameObject").Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(newAudio);
    }
}
