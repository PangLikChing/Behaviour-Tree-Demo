using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class RemoveNoice : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// For every points in the pointsOfInterest list
		for (int i = 0; i < castleGuard.pointsOfInterest.Count; i++)
        {
			// If the point in pointsOfInterest is the same as the investigationDestination
			if (castleGuard.pointsOfInterest[i] == castleGuard.investigationDestination)
            {
				// Remove that point
				castleGuard.pointsOfInterest.RemoveAt(i);

				// Break out of the for loop
				break;
            }
        }

		// Reset investigate destination
		castleGuard.investigationDestination = new Vector3(99999, 99999, 99999);

		// Return success
		return TaskStatus.Success;
	}
}