using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class PlayMotion : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Play walking animation
		castleGuard.animator.SetTrigger("Motion");

		// Throw a debug message
		Debug.Log("Playing walking animation");

		// Return success
		return TaskStatus.Success;
	}
}