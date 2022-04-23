using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class Patrol : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// If there is no patrol destination for the castle guard
		if (castleGuard.patrolDestination == null)
        {
			// Return failure
			return TaskStatus.Failure;
        }

		// Go to castleGuard's destination
		castleGuard.GetComponent<NavMeshAgent>().SetDestination(castleGuard.patrolDestination);

		// Return success
		return TaskStatus.Success;
	}
}