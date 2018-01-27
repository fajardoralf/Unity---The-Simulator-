using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class Menu_Button_Sound : MonoBehaviour, IPointerEnterHandler {

	private AudioSource audioSource;

	public void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		audioSource.Play ();
	}

}