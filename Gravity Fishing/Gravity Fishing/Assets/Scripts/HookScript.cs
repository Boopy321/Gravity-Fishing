using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HookScript : MonoBehaviour 
{
	public bool wasPressed;
	public List<Transform> planets;
	Vector3 planetAverage;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Planet")) 
		{
			planets.Add(other.transform);
			UpdateAverage();
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag ("Planet")) 
		{
			planets.Remove(other.transform);
			UpdateAverage();
		}
	}
	
	void UpdateAverage ()
	{
		planetAverage = new Vector3(0,0,0);
		foreach(Transform planet in planets)
		{
			planetAverage += planet.position;
		}
		planetAverage = planetAverage / (planets.Count);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			wasPressed = true;
		}


		//if (wasPressed == true) 
		//{
			//GetComponent<Rigidbody2D>().isKinematic = false;
		//}

		//transform.up = (transform.position - planetAverage).normalized;
	}
}
