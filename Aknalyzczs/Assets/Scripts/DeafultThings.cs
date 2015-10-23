using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeafultThings : MonoBehaviour {
	public int startZdrowie=100;
	public int Armor=100;
	public int Zdrowie;
	public int obrazenia= 5;
	public AudioSource bol;
	public Slider healthSlider;
	public GameObject wrog1;
	public Canvas smierc;
	public AudioSource noteopen;
	public Image note;
	public Animator anim2;
	public Canvas notatnik;
	public bool wlaczony;
	public Image przycisk;

	// Use this for initialization
	void Awake(){
		Zdrowie = startZdrowie;
	}
	void Start () {
		przycisk.enabled = false;
		wlaczony = false;
		note.enabled = false;

		noteopen.enabled = false;
		Cursor.visible = false;
		smierc.enabled = false;

	}
	
	void Update () {

		if (Input.GetKeyDown (KeyCode.N)) {
			anim2.SetBool ("klikN", true);
			wlaczony = true;
			note.enabled = false;

		}
			

		healthSlider.value = Zdrowie;
		if(Input.GetMouseButtonDown (1)&& Zdrowie>=5){
			Zdrowie-=obrazenia;
			healthSlider.value=Zdrowie;
			Debug.Log(Zdrowie);
	
			bol.Play();

		}


		if (Zdrowie < 1) {
			smierc.enabled=true;
			Cursor.visible=true;



		}


	}

	public void restart(int scena){
		Application.LoadLevel (scena);
	}
	public void wyjscie(){
		Application.Quit ();
	}


}
