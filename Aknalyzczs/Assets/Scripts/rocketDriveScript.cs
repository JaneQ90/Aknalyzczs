﻿using UnityEngine;
using System.Collections;

public class rocketDriveScript : MonoBehaviour {
    public float speed = 10f;

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
}
