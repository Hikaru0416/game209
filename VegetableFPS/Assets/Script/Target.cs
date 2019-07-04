using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private int ClickCount;

    // Start is called before the first frame update
    void Start()
    {
        ClickCount = 0;

    }

    void OnTriggerEnter(Collider Bullet)
    {
        ClickCount++;
    }

    // Update is called once per frame
    void Update()
    {   
        if (ClickCount >= 3)
        {
            this.gameObject.transform.Translate(0, 0.2f, 0);
        }
    }
}
