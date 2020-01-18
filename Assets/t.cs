using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	AudioSource source;
	public float a = 10; 
	public float b = -4;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		source.pitch =  Mathf.Pow(2, (a + b)/12.0f);  

		Vector2 pos = Input.mousePosition;//Input.GetTouch (0).position;

		source.pitch =  Mathf.Pow(2, ((pos[0] / Screen.height) * 10 + (pos[1] / Screen.width) * -4)/12.0f);  
		//Debug.Log (((pos[0] / Screen.height) * 10) + " " + ((pos[1] / Screen.width) * -4));


	}


}
