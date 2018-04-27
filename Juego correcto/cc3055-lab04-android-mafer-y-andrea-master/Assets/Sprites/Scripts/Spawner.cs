using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject meteoro;
    public float spawnTime = 4f;
    private float elapsedTime = 0f;
    private GameObject clone;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            float random = Random.Range(-3f, 3f);
            clone=Instantiate(meteoro, new Vector3(random, 8, 0), Quaternion.identity);
            clone.SetActive(true);
            elapsedTime = 0;
        }

    }
}
