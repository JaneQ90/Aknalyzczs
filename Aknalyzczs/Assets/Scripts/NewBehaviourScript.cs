using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public CharacterController charCtrl;
	private Transform player;
	private Transform enemy;
	public float obrotSpeed = 4.0f;
	public float predkoscRuchu = 5.0f;
	public float zasieg = 30.0f;
	public float aktWysSkoku= 0f;
	public float odstep = 2.5f;
	public bool czyDuch;
	
	// Use this for initialization
	void Start () {
		charCtrl = GetComponent<CharacterController> ();
		enemy = transform;
		GameObject go = GameObject.FindWithTag ( "Gracz");
		player = go.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		float dystans = Vector3.Distance (enemy.position, player.position);
		
		if (dystans < zasieg && dystans > odstep) {
			enemy.rotation = Quaternion.Slerp (enemy.rotation, Quaternion.LookRotation (player.position - enemy.position), predkoscRuchu * Time.deltaTime);
			enemy.position += enemy.forward * predkoscRuchu * Time.deltaTime;
			
			if (!charCtrl.isGrounded ){
				aktWysSkoku += Physics.gravity.y * Time.deltaTime;
			}
			Debug.Log(charCtrl.isGrounded);
			
			if(!czyDuch) {
				//Tworzymy wektor odpowiedzialny za ruch.
				//x - odpowiada za ruch lewo/prawo,
				//y - odpowiada za ruch góa/dół,
				//z - odpowiada za ruch przó/tył.
				Vector3 ruch = new Vector3(enemy.forward.x, aktWysSkoku, enemy.forward.z);
				//Ruch wroga.
				charCtrl.Move(ruch * predkoscRuchu * Time.deltaTime);
			}  else {
				//Tryb ducha
				enemy.position += enemy.forward * predkoscRuchu * Time.deltaTime;
			}
			
		}
	}
}