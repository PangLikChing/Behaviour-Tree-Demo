using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class PlayAnimation2 : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Play Idle2 animation
		castleGuard.animator.SetTrigger("Idle2");

		// Throw a debug message
		Debug.Log("Playing idle animation 2");

		// Return success
		return TaskStatus.Success;
	}
}