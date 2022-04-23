using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class IsDead : Conditional
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// If the castle guard is dead
		if (castleGuard.isDead == true)
        {
			// Return success
			return TaskStatus.Success;
		}
		// Else
		else
        {
			// Return failure
			return TaskStatus.Failure;
        }
	}
}