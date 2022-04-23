using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class PlayAnimation3 : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Play Idle3 animation
		castleGuard.animator.SetTrigger("Idle3");

		// Throw a debug message
		Debug.Log("Playing idle animation 3");

		// Return success
		return TaskStatus.Success;
	}
}