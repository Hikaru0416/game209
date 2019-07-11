using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int hitPoint = 100; //HP
    public static float kill;
    private void Start()
    {
        kill = 0;
    }
    void Update () {
		if (hitPoint <= 0)
        {
            Destroy(gameObject);
            kill=kill+1;
        }

	}
    public void Damage(int damage)
    {
        hitPoint -= damage;
    }
    public static float GetKill()
    {
        return kill;
    }
}
