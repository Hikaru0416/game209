using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static float countTime = 300;
  //public float Timetokuten;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime; //スタートしてからの秒数を格納
        GetComponent<Text>().text = countTime.ToString("F2"); //小数2桁にして表示

        /*void OnCollisionEnter(Collision collision)
            {
                if (collision.gameObject.name == "Goal")
                {
                    Timetokuten = countTime;

                }

            }
            */

    }
    public static float GetCountTime()
    {
        return countTime;
    }
    /*public float GetTimeTokuten()
    {
        return Timetokuten;
    }*/

}
