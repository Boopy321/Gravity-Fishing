using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HookScript : MonoBehaviour 
{
	public bool wasPressed;
	public Transform planet;
	Vector3 planetAverage;

	void Start()
	{
		Time.timeScale = 1;
		GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2(-100f, 0), ForceMode2D.Impulse);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Planet")) 
		{
			planet = other.transform;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			wasPressed = true;
		}
	}

	void FixedUpdate()
	{
		if (planet != null) 
		{
			Vector3 temp = (planet.position - transform.position).normalized;
			float angle = Mathf.Atan2(temp.x, temp.y) * Mathf.Rad2Deg;
			GetComponent<Rigidbody2D>().MoveRotation(-angle);

		}
	}
}
