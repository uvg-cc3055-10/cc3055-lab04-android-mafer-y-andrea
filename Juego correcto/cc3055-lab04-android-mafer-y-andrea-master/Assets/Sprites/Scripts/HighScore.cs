using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    public Text hs;
	// Use this for initialization
	void Start () {
        hs.text = PlayerPrefs.GetFloat("HighScore").ToString("F0");
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
