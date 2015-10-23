using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class filler : MonoBehaviour {
	public Image nacisk, obramowanie, background;
	public float timer=0f;
	public bool wcoli;
	public Animator filerAnim;
	public Image progressbar;
	public AudioSource woda;
	public AudioSource klik;
	public AudioClip klik2;
	void Start () {
		background.enabled = true;
		woda.enabled = false;
		nacisk.enabled = false;	
		obramowanie.enabled = false;
		klik.enabled = false;
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			nacisk.enabled=true;
			Debug.Log ("Wlazlem");
		}
	}
	void OnTriggerStay(Collider other){
		if (other.tag == "Player") 
		{
			wcoli=true;
			background.enabled=false;
			nacisk.enabled=true;
			obramowanie.enabled=true;

		
			Debug.Log ("Nacisnalem");
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") 
		{
			wcoli=false;
			background.enabled=true;
			nacisk.enabled = false;
			obramowanie.enabled=false;
			Debug.Log ("Wylazlem");

		}
	}
	void Update (){
		GameObject ThePlayer = GameObject.FindWithTag ("skrypt");
		healthpot skrypt = ThePlayer.GetComponent<healthpot> ();
		if (wcoli == true && Input.GetKey(KeyCode.E) && skrypt.potAmount <5){


			timer+= Time.deltaTime;
			filerAnim.SetBool ("czyNapelnia", true);
			woda.enabled=true;

		}
		else {
			woda.enabled=false;
			timer = 0f;
			filerAnim.SetBool ("czyNapelnia", false);

		}
		if (timer >= 1.1f && skrypt.potAmount < 5) {

			skrypt.potAmount += 1;
			skrypt.howMuchPot.text = ("") + skrypt.potAmount;
			timer = 0f;
		
		}

	}

	}