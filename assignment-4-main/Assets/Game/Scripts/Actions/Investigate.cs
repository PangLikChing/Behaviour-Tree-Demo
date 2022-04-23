using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class Investigate : Action
{
	CastleGuard castleGuard;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
	{
		// Initlaize a temp Vector3 object
		Vector3 closest = new Vector3(9999999, 999999, 999999);

		// For every points in the pointsOfInterest list
		for (int i = 0; i < castleGuard.pointsOfInterest.Count; i++)
        {
			// If that point in pointsOfInterest list is closer than that in closest
			if (Vector3.Distance(castleGuard.pointsOfInterest[i], castleGuard.transform.position) <= Vector3.Distance(closest, castleGuard.transform.position))
            {
				// Set cloest to that point in pointsOfInterest list
				closest = castleGuard.pointsOfInterest[i];
			}
        }

		// Go to the closest point
		castleGuard.GetComponent<NavMeshAgent>().SetDestination(closest);

		castleGuard.investigationDestination = closest;

		// Return success
		return TaskStatus.Success;
	}
}