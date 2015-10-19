using UnityEngine;
using System.Collections;

public class Cam1ChangeScript : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;

	private void press(){

		if(cam1.enabled=true && Input.GetKeyDown(KeyCode.E))
	{
		cam1.enabled = false;
		cam2.enabled = true;
	}
	}

}
