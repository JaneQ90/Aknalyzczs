using UnityEngine;
using System.Collections;

public class animacje : MonoBehaviour {
	public Animation anim;
	IEnumerator Start() {
		anim = GetComponent<Animation>();
		anim.Play(anim.clip.name);
		yield return new WaitForSeconds(anim.clip.length);
	}
}