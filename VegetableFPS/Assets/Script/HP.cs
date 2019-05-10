using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int hitPoint = 100; //HP

	void Update () {
		if (hitPoint <= 0)
        {
            Destroy(gameObject);
        }

	}
    public void Damage(int damage)
    {
        hitPoint -= damage;
    }
}
