using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {
    //Zasięg / range
    public float range = 100.0f;
    //co ile / how often you can shoot
    public float wait = 2f;
    //odliczanie do nastepnego strzału / wait until you can shoot again
    public float countdownToNextShoot = 0f;

    //obiekt pocisku / bullet object
    public GameObject bulletPrefab;
    //obrażenia za strzał / damage per hit
    public float hitDamage = 50.0f;
	// Use this for initialization
	public AudioClip shootSound;
	public AudioSource source;

	void Start () {
		//*source = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	public void shoot () {
	//odliczanie do strzału / countdown to nex shoot
    if (countdownToNextShoot < wait)
        {
            countdownToNextShoot += Time.deltaTime;
        }
    //strzał następuje po kliknięciu jeżeli zakoczyło się odliczanie / shoot when click if countdown is finished
    if(/*Input.GetMouseButton(0) && */countdownToNextShoot >= wait)
        {
            countdownToNextShoot = 0;

			//source.PlayOneShot(shootSound);
            //pobranie infermacji o obiekcie w który celujemy / get information about object you aim
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            //pobranie informacji w co trafilismy / get information what was hited
            RaycastHit hitInfo;
            //sprawdzenie czy trafiony obiekt by w zasiegu / check if hit object was in range
            if(Physics.Raycast(ray, out hitInfo, range))
            {
                // informacja o obiekcie / information about object
                Vector3 hitPoint = hitInfo.point;
                //pobranie info o trafionym obiekcie / get info about hited object
                GameObject go = hitInfo.collider.gameObject;

                //Debug.Log("hit Object: " + go.name); //nazwa trafionego obiegtu / name of hited object
                //Debug.Log("hitInfo Point: " + hitPoint); // współrzędne trafionego objektu / position of hited object

                //Zadane obrażenia trafionemu obiektowi / dealt damage
                hit (go);

                if(bulletPrefab != null)
                {
                	Instantiate(bulletPrefab, hitPoint, Quaternion.identity);
                }

            }
        }
	}
    void hit (GameObject go)
    {
        healthScript health = go.GetComponent<healthScript>();
        if (health != null)
        {
            health.takenDamage(hitDamage);
        }
		if (source != null)
		{
			source.PlayOneShot(shootSound);
		}
		
	}
}