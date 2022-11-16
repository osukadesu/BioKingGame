using UnityEngine;
using UnityEngine.AI;

public class EnemyStateManager : MonoBehaviour
{
    public int time;
    public float vel = 8f, y;
    public bool timerotate;
    public GameObject target;
    public float distance = 2;
    public NavMeshAgent agent;
    public EnemyBaseState currentState;
    public EnemyIdleState idleState = new EnemyIdleState();
    public EnemyGoToTargetState goToTargetState = new EnemyGoToTargetState();
    void Start()
    {
        currentState = idleState;
    }
    void FixedUpdate()
    {
        currentState=goToTargetState;
        currentState.EnterState(this);
    }
    public void SwitchStates(EnemyBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
