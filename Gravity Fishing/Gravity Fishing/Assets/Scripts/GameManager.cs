using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour {

	public PointEffector2D m_gravity; // Useless at the moment
	public GameObject Hook; //Game Hook
	public GameObject Menu;

	public GameObject BlackholePrefab;
	public BlackHole blackhole;
	public Vector3 Velocity;


	float zdepth= 30.0f;

	List<Vector3> applyForcelist;
	List<BlackHole> m_objects;

	private bool m_menu;
	
	void Awake () {
	
		//Screen.orientation = ScreenOrientation.Landscape;
		//SoundManager.Instance.StartGame ();
	}

	// Use this for initialization
	void Start () {
		//Blackhole list
		m_objects = new List<BlackHole> ();
		// Force List from the blackholes
		applyForcelist = new List<Vector3> ();
		//Velocity = Vector3 (1, 1, 1);

		m_menu = false;
		var blackholeobject = new GameObject ("Blackhole");
		blackhole = blackholeobject.AddComponent<BlackHole> ();;
		m_objects.Add (blackhole);
	
	}
	
	void Update () 
	{
		//Hook.transform.Translate(Velocity * Time.deltaTime);
		// Clone Blackholes
		if (m_menu == true) {
			RunMenu ();
		}
		else {
			RunGame ();
		}

	}	

	void RunMenu()
	{
		Menu.SetActive (true);
	
	}

	void RunGame()
	{
		Hook.SetActive (true);
		if (Input.GetMouseButtonDown (0)) 
		{
			print ("Click");
			
			Vector3 pos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, zdepth));
			//var blackholeobject = new GameObject ("Blackhole" + m_objects.Count);
			var clone = Instantiate (BlackholePrefab, pos, new Quaternion ()) as GameObject;
			if(clone.GetComponent<BlackHole>() == null)
			{
				Debug.Log("Clone is Null");
				
			}
			else
			{
				m_objects.Add(clone.GetComponent<BlackHole>());
			}
		};

	}

}
