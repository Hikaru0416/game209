using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int TargetHP = 30;
    private ParticleSystem particle;

    // Start is called before the first frame update
    void Awake()
    {
        particle = this.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (TargetHP == 0)
        {
            this.gameObject.transform.Translate(0, 0.2f, 0);
        }
    }

    public void TargetDamage(int Targetdamage)
    {
        TargetHP -= Targetdamage;
    }
}
