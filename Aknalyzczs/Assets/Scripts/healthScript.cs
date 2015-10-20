using UnityEngine;
using System.Collections;

public class healthScript : MonoBehaviour {
    public float health = 100.0f;
	public float duration = 1f;
    public void takenDamage(float amt)
    {
        Debug.Log("Taken Damage: " + amt);
        health -= amt;
		if (health <= 0)
		{
			Die ();			
		}
 

    }
    public void Die()
	{
		Destroy(gameObject,10);
	
    }
    public bool isDead()
    {
        if (health <= 0)
        {
            return true;
        }
        return false;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

}
