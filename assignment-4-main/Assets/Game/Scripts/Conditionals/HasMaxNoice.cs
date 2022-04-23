using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class HasMaxNoice : Conditional
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
        // If the number of noice recorded is not larger than the maxPointsOfInterest
        if (castleGuard.pointsOfInterest.Count < castleGuard.maxPointsOfInterest)
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