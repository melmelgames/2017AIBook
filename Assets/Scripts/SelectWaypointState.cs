using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWaypointState : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        TankAI tankAI = animator.gameObject.GetComponent<TankAI>();
        tankAI.SetNextPoint();
    }

}
