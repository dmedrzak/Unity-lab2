using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour {

    public Transform[] coinSpawns;
    public GameObject[] coin;
	// Use this for initialization
	void Start () {
        Spawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Spawn()
    {
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            int coinfFlip = Random.Range(0, 2);
            int coinSelected = Random.Range(0, coin.Length);
            if (coinfFlip > 0)
                Instantiate(coin[coinSelected], coinSpawns[i].position,Quaternion.identity);
        }
    }
}
