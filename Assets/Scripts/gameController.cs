using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

	public GameObject HSPanel;
	private Animator anim;
	public Text HSText;

	// Use this for initialization
	void Start () {
		anim = HSPanel.GetComponent<Animator>();
		gameOver();
		getHighScore();
	}

	// Update is called once per frame
	void Update () {

	}

	public void playGame(){
		SceneManager.LoadScene("main");
	}

	public void Quit(){
		Application.Quit();
	}

	public void playHSPanel(){
		anim.SetTrigger("playHSAnim");
	}

	public void backHSPanel(){
		anim.SetTrigger("backHSAnim");
	}

	public void gameOver(){
		// to be continued
		PlayerPrefs.SetString("HighScore","52345");
	}

	private void getHighScore(){
		HSText.text = PlayerPrefs.GetString("HighScore");
	}
}
