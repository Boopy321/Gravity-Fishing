using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public PointEffector2D m_gravity; // Useless at the moment
	public GameObject Hook; //Game Hook
	public ParticleSystem m_particles; //Later on Particle

	public BlackHole Blackhole;

	public GameObject m_blackhole;

	//Click Depth
	float zdepth= 30.0f;
	
	List<GameObject> m_objects;
	
	void Awake () {
	
		//Screen.orientation = ScreenOrientation.Landscape;
		//SoundManager.Instance.StartGame ();
	}

	// Use this for initialization
	void Start () {

		m_objects = new List<GameObject> ();

		m_blackhole = GameObject.FindGameObjectWithTag("BlackHole");
		//REMOVE ON GAME BUILDS, IN FOR TESTING
		m_objects.Add (m_blackhole);

		Hook = GameObject.FindGameObjectWithTag("Hook");
	}
	
	void Update () 
	{

		//Sphere collider to apply Gravity or not. 

		if(Input.GetMouseButtonDown(0))
	    {
			print ("Click");

			GameObject clone;
			//Debug.Log (Input.mousePosition);
			//Broken Stuff. 
			Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zdepth));
			//pos *= (distance);
			//Debug.Log (pos);
			//pos.z = 1;
			//Clones a blackhole object to worldspace
			clone = Instantiate(m_blackhole,pos,new Quaternion()) as GameObject;
			m_objects.Add(clone);

		};

		//Test Distances
		if(Input.GetKey(KeyCode.Space))
	   	{
			for( int a = 0; a < m_objects.Count; a++)
			{
				float Distance = Vector3.Distance (m_objects[a].transform.position, Hook.transform.position);
				print("Distance to other: " + Distance);
			}
		}



	}	
	
}
