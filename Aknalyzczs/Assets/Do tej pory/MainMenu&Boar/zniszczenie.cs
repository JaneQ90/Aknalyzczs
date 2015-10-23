using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class zniszczenie : MonoBehaviour {
	public RawImage image;	
	public RawImage end;
		
	void Start () {
		Cursor.visible = true;
		end.enabled = false;
	}

	void Update () {
		if (image.color.a<=0.05)
			Destroy(image);
		if (end.color.a >= 0.95)
			Application.Quit ();
	}
}
