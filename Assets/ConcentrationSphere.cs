using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcentrationSphere : MonoBehaviour {

	public GameObject knob;

	float timer = 0; 
	public bool isActive = false;
	// Use this for initialization
	void Start () {
		
	}
	
	void Update() {
		Vector2 temp = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		temp = temp.normalized * 2;
		knob.transform.position = new Vector3 (temp[0], temp[1], gameObject.transform.position[2]);
		if (knob.transform.position [0] + knob.transform.position [1] == 1 && knob.transform.position[0] * knob.transform.position [1] == 1) {
			if (isActive) {
				Debug.Log ("yes");
			}

		}
	}

	void FixedUpdate()
	{
		RaycastHit hit;


		if (Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition), out hit)){ 

			if (hit.transform == gameObject.transform){
				timer += Time.fixedDeltaTime;
				Debug.Log ("Active");
				isActive = true;
			} else {
				Debug.Log ("False");
				timer = 0;
				isActive = false;
			}
		}
	}

}