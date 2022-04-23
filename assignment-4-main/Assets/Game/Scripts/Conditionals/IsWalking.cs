using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class IsWalking : Conditional
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// If the animation in the animator has finished
		if (castleGuard.animator.GetCurrentAnimatorStateInfo(0).IsName("Motion"))
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