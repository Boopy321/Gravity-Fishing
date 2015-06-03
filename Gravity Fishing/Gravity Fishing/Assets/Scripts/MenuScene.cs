using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour {

	public Button play;

	void start()
	{
		play.onClick.AddListener (() => {
			Switch ();});

	}


	void Switch()
	{
		Application.LoadLevel ("Jarrods");
	}
}
