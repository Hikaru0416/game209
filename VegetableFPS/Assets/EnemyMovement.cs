using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private int ClickCount = 0;
    public Transform target;
    static Vector3 pos;
    NavMeshAgent agent;

    float agentToPatroldistance;
    float agentToTargetdistance;

    public void DoPatrol()
    {
        var x = Random.Range(-20.0f, 20.0f);
        var z = Random.Range(-20.0f, 20.0f);
        pos = new Vector3(x, 0, z);
        agent.SetDestination(pos);
    }

    public void DoTracking()
    {
        pos = target.position;
        agent.SetDestination(pos);
    }

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }
    
    void Start()
    {
        DoPatrol();
    }

    void Update()
    {
        //Agentと目標値の距離
        agentToPatroldistance = Vector3.Distance(this.agent.transform.position, pos);

        //AgentとPlayerの距離
        agentToTargetdistance = Vector3.Distance(this.agent.transform.position, target.transform.position);

        if(agentToTargetdistance <= 15f)
        {
            DoTracking();
        }else if(agentToPatroldistance < 5f)
        {
            DoPatrol();
        }

    }
}