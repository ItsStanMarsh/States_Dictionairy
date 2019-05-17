using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Move
{
    enum EnemyState
    {
        idling,
        tracking,
        attacking
    }

    EnemyState LastState, currentState = EnemyState.idling;
    Transform ts;
    Transform tsPlayer;
    Vector3 distanceAway;


     
    void Start()
    {
        ts = GetComponent<Transform>();
        TSset(ts);
        tsPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        LastState = currentState;
    }

    void Update()
    {
        CheckDistance();

        if(currentState == EnemyState.attacking)
        {
            Attacking();
        }
        else if(currentState == EnemyState.tracking)
        {
            Tracking();
        }

        LastState = currentState;
    }

    void CheckDistance()
    {
        distanceAway = ts.position - tsPlayer.position;
        float actualDistance = Mathf.Sqrt((distanceAway.x * distanceAway.x) + (distanceAway.y * distanceAway.y));

        if (actualDistance <= 2)
        {
            currentState = EnemyState.attacking;
        }
        else if (actualDistance <= 9)
        {
            currentState = EnemyState.tracking;
        }
        else
            currentState = EnemyState.idling;
    }

    void Attacking()
    {
        print("you are dead now");
    }

    void Tracking()
    {
        ts.position -= distanceAway.normalized * Time.deltaTime * 3;
    }

}
