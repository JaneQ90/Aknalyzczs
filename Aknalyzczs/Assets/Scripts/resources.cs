using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections;

public class resources : MonoBehaviour {

	public int resourceAmountslider;
	public int resource;
	public int armorPrice= 35;
	public Slider resourceSlider;
	public Slider armorAmountSlider;
	public int Armor;


	// Use this for initialization
	void Start () {
		Armor = 23; 
		resource = 2300;

	
	}
	void Trader (){
		if (resourceAmountslider > armorPrice) {
			armorAmountSlider.value += 1.0f;
		}

	}
	// Update is called once per frame
	void Update () {
		resourceAmountslider = (int)resourceSlider.value;
		

	
	}
}
