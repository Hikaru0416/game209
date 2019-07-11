using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static float countTime;
  //public float Timetokuten;
        void Start()
    {
        countTime = 300;
    }

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime; //スタートしてからの秒数を格納
        GetComponent<Text>().text = countTime.ToString("F2"); //小数2桁にして表示

    }
    
    public static float GetCountTime()
    {
        return countTime;
    }
   
}
