using UnityEngine;
using System.Collections;

public class KillHole : MonoBehaviour {

	public GameObject blackhole;
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D hook) {

		if (hook.CompareTag ("Hook")) {
			Destroy(blackhole);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
