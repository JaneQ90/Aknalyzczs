using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class obslugamenu : MonoBehaviour {
	public Canvas quitMenu;
	public Button btnStart;
	public Button btnExit;
	public RawImage end;
	public Canvas Menu;
	public Animator przyciemnienie;

	// Use this for initialization
	void Start () {
		Menu = (Canvas)GetComponent<Canvas>();
		quitMenu = quitMenu.GetComponent<Canvas>(); 
		btnStart = btnStart.GetComponent<Button> ();
		btnExit = btnExit.GetComponent<Button> ();
		quitMenu.enabled = false; 
		end.enabled = false;
		przyciemnienie.enabled = false;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			quitMenu.enabled = !quitMenu.enabled;
		}
		if (end.color.a >= 0.93f) {
			Application.LoadLevel (2);
		}
	}
	public void Exit() {
		quitMenu.enabled = true;
		btnStart.enabled = false;
		btnExit.enabled = false;
	}
	public void rozpoczecie () {
		end.enabled = true;
		przyciemnienie.enabled = true;
	}
	public void Nie(){
		quitMenu.enabled = false; //Ukrycie menu z pytaniem o wyjście z gry.
		btnStart.enabled = true; //Uaktywnienie przycisku 'Start'.
		btnExit.enabled = true; //Uaktywnienie przycisku 'Wyjscie'.
	}
	public void Tak(){
		end.enabled = true;
		quitMenu.enabled = false;
		przyciemnienie.enabled = true;



	}
}


