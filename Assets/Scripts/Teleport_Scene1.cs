using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Teleport_Scene1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			SceneManager.LoadScene (1);
		}
	}
}
