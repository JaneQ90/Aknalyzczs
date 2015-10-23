using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class dwa : MonoBehaviour {

	public Animator pressAny, panel;
	public Canvas menu;
	public Canvas napis;
	private bool Bulin;
	public RawImage fader;
	public Button start;
	public Button exit;
	public RawImage fader2;
	public float timer;

	void Awake(){

	
	Cursor.visible = true;
	}


	void Start () {
		timer = 0f;
		fader2.enabled = false;
		GetComponent<Animator> ();
		napis.enabled = true;
		menu.enabled = false;


	
	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			menu.enabled = !menu.enabled;
			pressAny.SetBool ("Bulin", true);
			panel.SetBool ("Bulin", true);
		} else if (Input.anyKeyDown) {
			menu.enabled = true;
			pressAny.SetBool ("Bulin", true);
			panel.SetBool ("Bulin", true);
		}
		if (fader2.color.a>=0.95f && fader2.enabled == true) {
			Application.LoadLevel (2);


		}







	}
}
