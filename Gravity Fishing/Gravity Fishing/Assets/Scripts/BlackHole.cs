using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class BlackHole : MonoBehaviour {

	public PointEffector2D m_gravity;

	public ParticleSystem m_particles;
	//public GameObject m_object;
	public GameObject m_hook;

	public float min_radius;
	public float mid_radius;
	public float max_radius;

	public float m_forceweak;
	public float m_forcemoderate;
	public float m_forceStrong;

	public float Distance;

	public bool m_Force;
	public bool m_dead;

	public int timer;

	private Vector3 Direction;
	private Vector3 Velocity;
	public Vector3 ForceDir;
	void Awake()
	{
		transform.Rotate (new Vector3 (-90, 0, 0));
		m_hook = GameObject.FindGameObjectWithTag("Hook");
		min_radius = 1.0f;
		mid_radius = 1.50f;
		max_radius = 10.0f;

		m_forceweak = 4.2f;
		m_forcemoderate = 1.40f;
		m_forceStrong = 4.60f;

		Velocity = new Vector3 (0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () 
	{	
		//m_hook.transform.Translate(Velocity * Time.deltaTime);
		//Vector3 direction = gameObject.transform.position - m_hook.transform.position;
		//direction.Normalize();
		//m_object.
		float Distance = Vector3.Distance(gameObject.transform.position, m_hook.transform.position);
		if (Distance < 0.8f) {
		}
		else if (Distance < min_radius) {
			ApplyForce ( m_forceStrong);
		} else if (Distance < mid_radius) {
			ApplyForce (m_forcemoderate);
		} else if (Distance < max_radius) {
			ApplyForce (m_forceweak);
		} else {
			m_Force = false;
		}
	}

	void OnDrawGizmos()
	{
		if (m_hook) {
			Gizmos.DrawLine (m_hook.transform.position, m_hook.transform.position + (10 * ForceDir));
		}
	}

	bool ApplyForce(float a_force)
	{

		Direction = (gameObject.transform.position - m_hook.transform.position).normalized;
		Direction = Direction * a_force;

		ForceDir = Direction.normalized;

		Velocity = a_force * Direction * Time.deltaTime;
		return true;
	}

	public Vector3 ReturnCurrentForce()
	{
		return m_forceweak * ForceDir;
	}
}
