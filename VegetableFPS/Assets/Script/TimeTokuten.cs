using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTokuten : MonoBehaviour
{
    float tokuten;
    
    // Start is called before the first frame update
    void Start()
    {
        /*float tokuten;
        tokuten = timerScript.GetTimeTokuten();
        Debug.Log(tokuten);
        */
        tokuten = Timer.GetCountTime();
        print(tokuten);
      
}

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = tokuten.ToString("F2");
    }

}