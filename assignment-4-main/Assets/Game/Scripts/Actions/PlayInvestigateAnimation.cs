using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class PlayInvestigateAnimation : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Play Investigate animation
		castleGuard.animator.SetTrigger("Investigate");

		// Return success
		return TaskStatus.Success;
	}
}