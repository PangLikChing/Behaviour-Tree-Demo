using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class IsNoiceListEmpty : Conditional
{
	CastleGuard castleGuard;

    public override void OnStart()
    {
        // Initialize
        castleGuard = GetComponent<CastleGuard>();
    }

    public override TaskStatus OnUpdate()
	{
        // If the pointsOfInterest list is empty
        if (castleGuard.pointsOfInterest.Count == 0)
        {
            // Return success
            return TaskStatus.Success;
        }
        else
        {
            // Return failure
            return TaskStatus.Failure;
        }
	}
}