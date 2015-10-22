using UnityEngine;
using System.Collections;

public class explosionPushScript : MonoBehaviour {
	public float ForceAmount;
	public float ForceRadius;

	// Use this for initialization
	void Start () {
		CreateExplosion(gameObject.transform.position, ForceRadius, ForceAmount);
	}
	
	public static void CreateExplosion(Vector3 pos, float radius, float force)
	{
		if (force <= 0.0f || radius <= 0.0f)
		{
			return;
		}
		
		// find all colliders and add explosive force
		Collider[] objects = UnityEngine.Physics.OverlapSphere(pos, radius);
		foreach (Collider h in objects)
		{
			Rigidbody r = h.GetComponent<Rigidbody>();
			if (r != null)
			{
				r.AddExplosionForce(force, pos, radius);
			}
		}
	}
}
