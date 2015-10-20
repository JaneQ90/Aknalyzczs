using UnityEngine;
using System.Collections;

public class shootWithBulletScript : MonoBehaviour {
    public float wait = 1f;
    public float countToFire = 0f;
    public GameObject bulletPrefab;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        countToFire -= Time.deltaTime;
        if(Input.GetMouseButton(1) && countToFire <= 0)
        {
            countToFire = wait;

            Instantiate(bulletPrefab, Camera.main.transform.position + Camera.main.transform.forward, Camera.main.transform.rotation);

        }
	
	}
}
