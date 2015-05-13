using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct Blackhole
{
	public GameObject blackhole;
	public float radius;
	public int timer;
}


public class GameManager : MonoBehaviour {

	public PointEffector2D m_gravity; // Useless at the moment
	public GameObject Hook; //Game Hook
	public ParticleSystem m_particles; //Later on Particle
	//public Canvas m_clickCanvas;
	float zdepth;
	public GameObject m_blackhole; // Actual BlackHole Object

	List<GameObject> m_objects;


	void Awake () {
	
		//Screen.orientation = ScreenOrientation.Landscape;
		//SoundManager.Instance.StartGame ();
	}

	// Use this for initialization
	void Start () {
		m_objects = new List<GameObject> ();
		m_blackhole = GameObject.FindGameObjectWithTag("BlackHole");
	//	m_clickCanvas = new Canvas ();
		zdepth = 15.0f;
	}
	
	void Update () 
	{

		//Sphere collider to apply Gravity or not. 
		for (int i = 0; i < m_objects.Count; i++) 
		{
	
		}

		if(Input.GetMouseButtonDown(0))
	    {
			print ("Click");

			GameObject clone;
			Debug.Log (Input.mousePosition);
			//Broken Stuff. 
			Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zdepth));
			//pos *= (distance);
			Debug.Log (pos);
			//pos.z = 1;
			//Clones a blackhole object to worldspace
			clone = Instantiate(m_blackhole,pos,new Quaternion()) as GameObject;
			m_objects.Add(clone);

		}
			//m_objects[i].blackhole;
			
			//Delete Blackholes after time
			//if(m_objects[i].timer <= 0)
			//{
			//	Destroy(m_objects[i].blackhole)
			//}

	}
	
}
