using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform hook;
	public bool wasPressed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			wasPressed = true;
		}
		
		if (wasPressed == true)
		{
			transform.position = new Vector3 (hook.position.x, hook.position.y, transform.position.z);
		}
	
	}
}
