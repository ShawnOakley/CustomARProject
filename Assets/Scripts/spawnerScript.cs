using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnerScript : MonoBehaviour {

	public Text myScore;
	public static spawnerScript instance;
	private GameObject dancer;
	private Animator anim;
	// Use this for initialization
	void Start () {
 		SpawnProcess();
	}

	void Awake() {
		if(instance==null){
			instance = this;
		}
	}

	// Update is called once per frame
	void Update () {

	}

	public void SpawnProcess(){
		InvokeRepeating("spawn", 2.5f, 1.5f);
	}

	void spawn(){
		GameObject x = (GameObject)Instantiate(Resources.Load("pointButton"));
		x.transform.parent = transform;

		RectTransform position = x.GetComponent<RectTransform>();
		position.localPosition = new Vector3(0,60, 0);
		position.localScale = new Vector3(1,1,1);
	}

	public void addScore(int theScore){
		myScore.text = (int.Parse(myScore.text) + theScore).ToString();
		removeKids ();
	}

	private void removeKids(){
		foreach(Transform child in transform) {
			Destroy (child.gameObject);
		}
	}

	public void makeMove(string danceMove) {
		dancer = GameObject.Find ("UserDefinedTarget-1/mremireh_o_desbiens");
		anim = dancer.GetComponent<Animator> ();
		anim.SetTrigger(danceMove);
	}
}
