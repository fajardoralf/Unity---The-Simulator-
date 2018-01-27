using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Outdoors : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKey("escape") ) {

			SceneManager.LoadScene(0);

		}
	
	}
	public void Return(){
		SceneManager.LoadScene(0);
	}

}
