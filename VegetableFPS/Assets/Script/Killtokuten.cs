using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Killtokuten : MonoBehaviour
{
    float killtokuten;
    float killtokuten1;
    float goukei;
    // Start is called before the first frame update
    void Start()
    {
        {
            killtokuten = HP.GetKill();
            print(killtokuten);
        }
        {
            killtokuten1 = Target.GetKill1();
            print(killtokuten1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        goukei = killtokuten + killtokuten1;
        GetComponent<Text>().text = goukei.ToString("F2");
    }
}