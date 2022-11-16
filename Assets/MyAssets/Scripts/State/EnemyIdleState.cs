using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{

    public void Rotate(EnemyStateManager enemy)
    {
        enemy.y = Random.Range(-3, 3);
    }
    public override void EnterState(EnemyStateManager enemy)
    {
        enemy.time += 1;
        if (enemy)
        {
            enemy.transform.Translate(enemy.transform.forward * enemy.vel * Time.fixedDeltaTime);
            enemy.transform.Rotate(new Vector3(0, enemy.y, 0));
            if (enemy.time >= Random.Range(100, 2500))
            {
                Rotate(enemy);
                enemy.time = 0;
                enemy.timerotate = true;
            }
            if (enemy.timerotate == true)
            {
                if (enemy.time >= Random.Range(50, 100))
                {
                    enemy.y = 0;
                    enemy.timerotate = false;
                }
            }
        }
        else
        {
            enemy.SwitchStates(enemy.goToTargetState);
        }
    }
}
