/*
 * Spawner.cs
 * Controla cada cuanto salen los meteoritos
 * Andrea Arguello 17801, Maria Fernanda Lopez 17160
 * 27/04/2018
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject meteoro;
    public float spawnTime = 1f;
    private float elapsedTime = 0f;
    private GameObject clone;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (elapsedTime < spawnTime)
        {
            //Contador para esperar 4 segundos entre cada meteoro
            elapsedTime += Time.deltaTime;
        }
        else
        {
            //Tira los meteoritos al azar entre +-3 en x
            float random = Random.Range(-3f, 3f);
            clone=Instantiate(meteoro, new Vector3(random, 8, 0), Quaternion.identity);
            //Clona el objeto antes de que se destruya
            clone.SetActive(true);
            //Vuelve a colocar el "contador" en 0
            elapsedTime = 0;
        }

    }
}
