using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.XR.MagicLeap;

public class t : MonoBehaviour {

	AudioSource source;
	public float a = 10; 
	public float b = -4;

	//MLInputController _controller;
   // public MagicLeapTouchpadGestureEvent touch;
	void Start () {
		source = GetComponent<AudioSource> ();
        /*
        MLInput.Start();
        MLInput.OnControllerButtonDown += OnButtonDown;
        MLInput.OnControllerButtonUp += OnButtonUp;
        _controller = MLInput.GetController(MLInput.Hand.Left);
        */
    }
/*
	void OnDestroy() {
		MLInput.OnControllerButtonDown -= OnButtonDown;
		MLInput.OnControllerButtonUp -= OnButtonUp;
		MLInput.Stop();
	}
	*/
	void Update () {

        Vector2 pos = Input.mousePosition;//Input.GetTouch (0).position;
        //Vector2 pos = touch.positionAndForce;//_controller.TouchpadGesture.Direction;
		source.pitch =  Mathf.Pow(2, ((pos[0] / Screen.height) * 10 + (pos[1] / Screen.width) * -4)/ 12.0f);  
	}

	/*
	void CheckControl() {
    
    }

	void OnButtonDown(byte controller_id, MLInputControllerButton button) {
		
	}

	void OnButtonUp(byte controller_id, MLInputControllerButton button) {
		
	}
	*/
}
