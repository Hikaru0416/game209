using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Totalscore : MonoBehaviour
{
    float tokuten1;
    float killscore;
    float killscore1;
    float Score;
    void Start()
    {
        ;
        {
            
            tokuten1 = Timer.GetCountTime();
            print(tokuten1);
        }
        {
            killscore = HP.GetKill();
            print(killscore);
        }
        {
            killscore1 = Target.GetKill1();
            print(killscore1);
        }

    }

    void Update()
    {
       Score = tokuten1 + killscore+killscore1;
       GetComponent<Text>().text = Score.ToString("F2");
    }
}
