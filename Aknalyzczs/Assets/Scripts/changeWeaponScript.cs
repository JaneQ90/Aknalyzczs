using UnityEngine;
using System.Collections;

public class changeWeaponScript : MonoBehaviour{
	
	/** Typy ataków jakie może wykonać gracz.*/
	public attackTypeScript attackTypeScript = attackTypeScript.bulletGun;
	private shootWithBullet2Script energyGun;
	private shootWithBulletScript fireGun;
	private ShootScript bulletGun;

	
	void Start()
	{
		energyGun = (shootWithBullet2Script)GetComponent<shootWithBullet2Script>();
		fireGun = (shootWithBulletScript)GetComponent<shootWithBulletScript>();
		bulletGun = (ShootScript)GetComponent<ShootScript>();
	}
	
	void Update()
	{
		changeWeapon();
		
		if (Input.GetMouseButton(0) && !isDead())
		{
			justShoot();
		}
	}

	public void justShoot()
	{
		switch (attackTypeScript)
		{
		case attackTypeScript.bulletGun:
			if (energyGun  != null)
			{
				bulletGun.shoot();
			}
			break;
		case attackTypeScript.fireGun:
			if (fireGun != null)
			{
				fireGun.shoot();
			}
			break;
		case attackTypeScript.energyGun:
			if (energyGun != null)
			{
				energyGun.shoot();
			}
			break;
		}
	}
	private void changeWeapon()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			attackTypeScript = attackTypeScript.energyGun;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			attackTypeScript = attackTypeScript.fireGun;
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			attackTypeScript = attackTypeScript.bulletGun;
		}
		
		
	}

	private bool isDead()
	{
		healthScript health = gameObject.GetComponent<healthScript>();
		if (health != null && health.isDead())
		{
			return true;
		}
		return false;
	}
	
}
