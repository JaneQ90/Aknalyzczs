using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scri2 : MonoBehaviour {
	public Image notes;
	public Image nacisk;
	public AudioSource pisanie;
	public Text notatka2;

	void Start () {
		notes.enabled = false;
		nacisk.enabled = false;	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			nacisk.enabled=true;
			Debug.Log ("Wlazlem");
		}
	}
	void OnTriggerStay(Collider other){
		if (other.tag == "Player" && Input.GetKeyDown (KeyCode.E)) 
		{
			notes.enabled = true;
			nacisk.enabled=false;
			pisanie.enabled=true;
			notatka2.enabled=true;
			Debug.Log ("Nacisnalem");
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") 
		{
			nacisk.enabled = false;
			Debug.Log ("Wylazlem");
			pisanie.enabled=false;
		}
	}
	
	}