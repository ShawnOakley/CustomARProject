using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void SpawnProcess(){
		InvokeRepeating("spawn", 2.5f, 1.5f);
	}

	void spawn(){
		GameObject x = (GameObject).Instantiate(Resources.Load("pointButton"));
		x.transform.parent = transform;
	}
}
