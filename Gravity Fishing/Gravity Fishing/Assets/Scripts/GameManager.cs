using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {





	void Awake () {
		playerScore = 0;
		enemyScore = 0;
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		
		if (Fade == null) {
			Fade = new Texture2D (1, 1);
			Fade.SetPixel (0, 0, new Color (1, 1, 1, 1));
		}
		Screen.orientation = ScreenOrientation.Landscape;
		SoundManager.Instance.StartGame ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void CreateBlackHole()
	{
		Instance
	}

}
