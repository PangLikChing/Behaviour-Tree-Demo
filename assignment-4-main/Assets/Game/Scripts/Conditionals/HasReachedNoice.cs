using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class HasReachedNoice : Conditional
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// If there is no points to investigate
		if (castleGuard.investigationDestination == null)
        {
			// Return success
			return TaskStatus.Success;
        }

		// If the distance between the castle guard and the noice is less than the turnDistance
		if (Vector3.Distance(castleGuard.transform.position, castleGuard.investigationDestination) <= castleGuard.turnDistance)
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