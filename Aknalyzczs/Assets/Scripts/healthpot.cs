using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class healthpot : MonoBehaviour {
	public int potAmount;
	public int maxPot=5;
	public int minPot=0;
	public int plusHealth=25;
	public int plusStamina=30;
	public Text howMuchPot;



	// Use this for initialization
	void Start () {

		potAmount = maxPot;
		howMuchPot.text = potAmount.ToString();
		Debug.Log (potAmount);
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject obiektZeSkryptemZdrowia = GameObject.FindWithTag ("skrypt");
		DeafultThings skrypt = obiektZeSkryptemZdrowia.GetComponent<DeafultThings> ();

		if (potAmount > minPot && Input.GetKeyDown (KeyCode.Tab) && skrypt.Zdrowie <=75) {
			potAmount -= 1;
			skrypt.Zdrowie+=plusHealth;
			Debug.Log (potAmount);
			howMuchPot.text=("")+potAmount;
			Debug.Log (skrypt.Zdrowie);
		}
	}
}
