using UnityEngine;
using System.Collections;

public class spiderScript : MonoBehaviour {
	public CharacterController charCtrl;
	private Transform player;
	private Transform enemy;
	public float obrotSpeed = 4.0f;
	public float predkoscRuchu = 5.0f;
	public float zasieg = 30.0f;
	public float aktWysSkoku= 0f;
	public float odstep = 2.5f;
	public float attackZone = 3f;
	public bool czyDuch;
	public Animator anim;
	public AudioSource walking;
	public int attack =5;
	public float timer = 0f;

	void Start () {

		anim = GetComponent<Animator>();
		charCtrl = GetComponent<CharacterController> ();
		enemy = transform;
		GameObject go = GameObject.FindWithTag ( "Player");
		player = go.transform;
		walking.enabled = false;
	}
	void Update () {
		GameObject ThePlayer = GameObject.FindWithTag ("skrypt");
		DeafultThings skrypt = ThePlayer.GetComponent<DeafultThings> ();

		float dystans = Vector3.Distance (enemy.position, player.position);
		
		if (dystans < zasieg && dystans > odstep) {
			enemy.rotation = Quaternion.Slerp (enemy.rotation, Quaternion.LookRotation (player.position - enemy.position), predkoscRuchu * Time.deltaTime);
			enemy.position += enemy.forward * predkoscRuchu * Time.deltaTime;
			anim.SetBool ("czyidzie", true);
			walking.enabled =true;

			
			if (!charCtrl.isGrounded) {
				aktWysSkoku += Physics.gravity.y * Time.deltaTime;
			}
			Debug.Log (charCtrl.isGrounded);
			
			if (!czyDuch) {
				Vector3 ruch = new Vector3 (enemy.forward.x, aktWysSkoku, enemy.forward.z);
				//Ruch wroga.
				charCtrl.Move (ruch * predkoscRuchu * Time.deltaTime);
			} else {
				//Tryb ducha
				enemy.position += enemy.forward * predkoscRuchu * Time.deltaTime;
			}
			
		} else {
			anim.SetBool ("czyidzie", false);
			walking.enabled=false;
		}
		if (dystans <= attackZone) {
			timer+=Time.deltaTime;
			anim.SetBool ("czyprzy", true);
			if(timer>=0.8f){
				skrypt.Zdrowie-=attack;
				timer=0f;
			}


		} else {
			anim.SetBool ("czyprzy", false);
		}
	}
}
