using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootscript : MonoBehaviour {
    public GameObject bulletPrefab;
    [SerializeField] private AudioClip se1;
    [SerializeField] private AudioClip se2;
    public float shotSpeed;
    public int shotCount = 30;
    private float shotInterval;

    void Start()
    {
        AudioSource k = GetComponent<AudioSource>();
        if(k!=null)
        {
            Debug.Log("kakka");
        }
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            shotInterval += 1;
            if(shotInterval % 5 == 0 && shotCount > 0)
            {
                shotCount -= 1;

                GameObject bullet = (GameObject)Instantiate(
                    bulletPrefab,
                    transform.position,
                    transform.parent.rotation
                   );
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);
                GetComponent<AudioSource>().PlayOneShot(se1);
                Destroy(bullet, 3.0f);
            }
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<AudioSource>().PlayOneShot(se2);
            shotCount = 30;
        }
	}
}
