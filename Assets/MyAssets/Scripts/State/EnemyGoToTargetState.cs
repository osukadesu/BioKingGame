using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGoToTargetState : EnemyBaseState
{
    public override void EnterState(EnemyStateManager enemy)
    {
        if (Vector3.Distance(enemy.target.transform.position, enemy.transform.position) < enemy.distance)
        {
            enemy.agent.SetDestination(enemy.target.transform.position);
            enemy.agent.speed = 3;
        }
        else
        {
            enemy.SwitchStates(enemy.idleState);
            enemy.agent.speed = 0;
        }
    }
}
