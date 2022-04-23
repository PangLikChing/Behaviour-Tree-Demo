using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class IsReachWaypoint : Conditional
{
	CastleGuard castleGuard;

    public override void OnStart()
    {
        castleGuard = GetComponent<CastleGuard>();
    }

    public override TaskStatus OnUpdate()
	{
        // If the agent reached the patrol destination
		if (Vector3.Distance(castleGuard.transform.position, castleGuard.patrolDestination) <= castleGuard.turnDistance)
        {
            // Return success
            return TaskStatus.Success;
        }
        else
        {
            // Return failure
            return TaskStatus.Failure;
        }
	}
}