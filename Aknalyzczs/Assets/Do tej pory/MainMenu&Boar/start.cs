	using UnityEngine;
	using UnityEngine.UI;
	using System.Collections;
	
	public class start : MonoBehaviour {
	public Animator anim;
	public RawImage rawimage;
	void Start (){
		rawimage.enabled = false;
	}
	public void btnstart(){
		rawimage.enabled = true;
		anim.SetBool ("klikniety", true);



	}



}
