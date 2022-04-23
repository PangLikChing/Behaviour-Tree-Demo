using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class UpdatePassedWaypointCount : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Increament passedWaypointCount
		castleGuard.passedWaypointCount += 1;

		// Return success
		return TaskStatus.Success;
	}
}