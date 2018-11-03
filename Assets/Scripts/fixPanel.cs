using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class fixPanel : MonoBehaviour {

	private string s = "";
	private bool onOff = false;
	// Use this for initialization
	void Start () {
		s = SceneManager.GetActiveScene().name;
	}

	// Update is called once per frame
	void Update () {

	}

	public void toggleFlash(){
		if (onOff==false) {
			CameraDevice.Instance.SetFlashTorchMode(true);
			onOff = true;
		} else {
			CameraDevice.Instance.SetFlashTorchMode(false);
			onOff = false;
		}
	}

	public void refresh(){
		SceneManager.LoadScene(s);
	}

}
