using UnityEngine;
using System.Collections;

public class crosshairScript : MonoBehaviour {
	/*pod tą zmianą podstawiamy obrazek.*/
	public Texture2D crosshairTexture;
	/*Pozycja naszego celownika.*/
	public Rect position;
	/** Czy wyświetlić celkownik.*/
	public bool widoczny = true;

	// Use this for initialization
	void Start () {
		//Ustawienie Pozycji dla celownika.
		position = new Rect (
			(Screen.width - crosshairTexture.width) / 2,
			(Screen.height - crosshairTexture.height) / 2,
			crosshairTexture.width, crosshairTexture.height);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.DrawTexture (position, crosshairTexture);
	}
}
