using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button_Main : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("escape")) {
			Application.Quit();
		}

	}

	public void MoveToMenu(){
		SceneManager.LoadScene (0);
	}

	public void ChangeScene(int index){
		SceneManager.LoadScene (index);

	}

	public void Exit(){
		Application.Quit ();
	}
}