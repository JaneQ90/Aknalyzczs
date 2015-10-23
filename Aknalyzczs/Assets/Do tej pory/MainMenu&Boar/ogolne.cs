using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ogolne : MonoBehaviour {
	public RawImage fader;	
		
	void Start () {
		Cursor.visible = false;
	}

	void Update () {
		if (fader.color.a >= 0.95f && Time.time>=3 )
			Application.LoadLevel (1);
	}
}
