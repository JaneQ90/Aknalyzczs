using UnityEngine;
using System.Collections;

public class damageScript : MonoBehaviour {
	public float damage = 10f;
	// Use this for initialization
	void OnCollisionEnter(Collision touch){
		GameObject go = touch.gameObject;
		healthScript health = (healthScript)go.GetComponent<healthScript> ();
		if (health != null){
			health.takenDamage (damage);
		}
	}
}