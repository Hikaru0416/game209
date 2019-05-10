using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeObject : MonoBehaviour {

    public int damage;
    public GameObject enemy;
    private HP hp;

	void Start ()
    {
        hp = enemy.GetComponent<HP>();
    }
	
	void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Shell"))
        {
            hp.Damage(damage);

            Destroy(other.gameObject);
        }
	}
}
