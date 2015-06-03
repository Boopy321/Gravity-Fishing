using UnityEngine;
using System.Collections;

public class DeleteBlackHole : MonoBehaviour {

	float timer;

	// Use this for initialization
	void OnTriggerStay2D () 
	{
		timer += Time.deltaTime;

		if (timer > 2.0f) {
			gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
