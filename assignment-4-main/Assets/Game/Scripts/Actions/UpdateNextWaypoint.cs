using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class UpdateNextWaypoint : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Increament nextWaypoint
		castleGuard.nextWaypoint++;

		// Return success
		return TaskStatus.Success;
	}
}