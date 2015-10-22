using UnityEngine;
using System.Collections;

public class DetonationScript : MonoBehaviour {
    public GameObject hitPrefab;
    public float damage = 200f;
    public float detonationRange;

    void OnTriggerEnter()
    {
        //Debug.Log("OnTriggerEnter");
        Detonation();
    }
    void Detonation()
    {
        Vector3 detonationPoint = transform.position;
        if(hitPrefab != null)
        {
            Instantiate (hitPrefab, detonationPoint, Quaternion.identity);
        }
        Destroy(gameObject);
        Collider[] colliders = Physics.OverlapSphere(detonationPoint, detonationRange);
        foreach (Collider c in colliders) {
            healthScript h = c.GetComponent<healthScript>();
            if (h !=null) { float dist = Vector3.Distance(detonationPoint, c.transform.position);
                float newDamage = 1f - (dist / detonationRange);
                h.takenDamage(damage * newDamage);
            }
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
