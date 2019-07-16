using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   
    bool test = true; // 変数宣言
    public int TargetHP = 30;
    private ParticleSystem particle;
    public static float kill1;
    private void Start()
    {
        kill1 = 0;
    }

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
            if (test == true)
            {
                kill1 = kill1 + 1;
                test = false;
            }
            
        }
    }

    public void TargetDamage(int Targetdamage)
    {
        TargetHP -= Targetdamage;
    }
    public static float GetKill1()
    {
        return kill1;
    }
}
