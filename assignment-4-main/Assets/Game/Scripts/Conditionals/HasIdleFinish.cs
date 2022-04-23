using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class HasIdleFinish : Conditional
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// See if the gameObject is idling
		bool isIdle = castleGuard.animator.GetCurrentAnimatorStateInfo(0).IsName("Idle1") || castleGuard.animator.GetCurrentAnimatorStateInfo(0).IsName("Idle2") || castleGuard.animator.GetCurrentAnimatorStateInfo(0).IsName("Idle3");

		// If the animation in the animator has finished
		if (isIdle && castleGuard.animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
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