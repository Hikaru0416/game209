using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeObject : MonoBehaviour {

    public int damage;
    private GameObject enemy;
    private HP hp;

	void Start ()
    {
        enemy = GameObject.Find("Zombie");
        hp = enemy.GetComponent<HP>();
        Debug.Log("Start");
    }
	
	void OnTriggerEnter(Collider other) {
        Debug.Log("あたた");
        if (other.CompareTag("Dummie"))
        {
            hp.Damage(damage);

            Destroy(other.gameObject);
        }
	}
}
