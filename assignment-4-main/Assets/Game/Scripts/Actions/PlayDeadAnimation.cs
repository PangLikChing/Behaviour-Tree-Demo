using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class PlayDeadAnimation : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Play Dead animation
		castleGuard.animator.SetTrigger("Dead");

		// Return success
		return TaskStatus.Success;
	}
}