using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private int ClickCount;
    private ParticleSystem particle;

    // Start is called before the first frame update
    void Awake()
    {
        ClickCount = 0;
        particle = this.GetComponent<ParticleSystem>();
    }


    void OnMouseDown()
    {
        ClickCount++;
    }

    // Update is called once per frame
    void Update()
    {   
        if (ClickCount >= 3)
        {
            particle.Play();
            this.gameObject.transform.Translate(0, 0.2f, 0);
        }
    }
}
