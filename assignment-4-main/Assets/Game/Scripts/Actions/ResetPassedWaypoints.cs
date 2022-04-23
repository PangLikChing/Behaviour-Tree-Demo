using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class ResetPassedWaypoints : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Reset passedWaypointCount
		castleGuard.passedWaypointCount = -1;

		// Return success
		return TaskStatus.Success;
	}
}