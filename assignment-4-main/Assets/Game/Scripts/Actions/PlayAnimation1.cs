using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class PlayAnimation1 : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Play Idle1 animation
		castleGuard.animator.SetTrigger("Idle1");

		// Throw a debug message
		Debug.Log("Playing idle animation 1");

		// Return success
		return TaskStatus.Success;
	}
}