using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScore : MonoBehaviour {
    public Text score1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float puntos = GameController.instance.score++;
        //score1.text = ; 
		
	}
}
