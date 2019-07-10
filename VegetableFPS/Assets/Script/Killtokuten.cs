using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Killtokuten : MonoBehaviour
{
    float killtokuten;
    // Start is called before the first frame update
    void Start()
    {
        killtokuten = HP.GetKill();
        print(killtokuten);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = killtokuten.ToString("F2");
    }
}