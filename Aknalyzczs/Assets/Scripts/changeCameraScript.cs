using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changeCameraScript : MonoBehaviour {
		public Canvas informations;
		public Text text;
		public GameObject trigger;
		public Camera cam0;
		public Camera cam1;
		public Camera cam2;
		public Camera cam3;
		public Camera cam4;
	
		public float countdown = 0f;
		public float wait = 2f;
		
		
		// Use this for initialization
		void Start () {
			useTextBox(false);
		}
		void OnTriggerEnter(Collider other)
		{
			Debug.Log("Enter");
			if (other.tag == "Player") {
				useTextBox (true);
				useText(cam0.enabled=true);
			}
		}
		void OnTriggerStay(Collider other)
		{
			Debug.Log("Player Stay");
			if (informations.enabled == true && Input.GetKeyDown(KeyCode.E) && countdown >= wait) 
			{
				countdown = 0;
				Debug.Log("E");
				if (cam0.enabled)
				{
					cam0.enabled = false;
					cam1.enabled = true;
				}
			else if (cam1.enabled)
			{
				cam1.enabled = false;
				cam2.enabled = true;
			}
			else if (cam2.enabled)
			{
				cam2.enabled = false;
				cam3.enabled = true;
			}
			else if (cam3.enabled)
			{
				cam3.enabled = false;
				cam4.enabled = true;
			}
			else if (cam4.enabled)
			{
				cam4.enabled = false;
				cam0.enabled = true;
			}

			}
			
		}
		void OnTriggerExit(Collider other) {
			Debug.Log("Exit");
			if (other.tag == "Player")
			{
				useTextBox(false);
			}
			
		}
		private void useTextBox (bool val)
		{
			informations.enabled = val;
		}
		private void useText (bool val)
		{
			if (text != null)
			{
				if (!val)
				{
					text.text = "E - Camera";
				}
				else
				{
					text.text = "E - Camera";
				}
			}
		}
		
		// Update is called once per frame
		void Update () {
			if (countdown < wait)
			{
				countdown += Time.deltaTime;
			}
			
			
		}
	}

