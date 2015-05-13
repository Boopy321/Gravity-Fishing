using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class BlackHole : MonoBehaviour {

	public PointEffector2D m_gravity;
	//public GameObject Hook;
	public ParticleSystem m_particles;

	Blackhole m_object;
	bool m_Force;
	bool m_dead;

	void Awake()
	{
		m_object.radius = 20.0f;
		m_object.timer = 10;
	}

	// Update is called once per frame
	void Update () 
	{		

		transform.Rotate (new Vector3 (0, 5, 0));
		/* BROKEN CODE
		 * float distance = Vector3.Distance(Hook.gameObject.transform.position,m_object.blackhole.transform.position); 
			//Apply Gravity to Objects within the Radius
			if(distance < m_object.radius)
			{
				ApplyForce(Hook);
			}
		*/
			//Delete Blackholes after time
			//if(m_objects[i].timer <= 0)
			//{
			//	Destroy(m_objects[i].blackhole)
			//}
	}

	void ApplyForce(GameObject a_object)
	{
		//Adjust the object position to give it a pull effect to 

	}
		
}
