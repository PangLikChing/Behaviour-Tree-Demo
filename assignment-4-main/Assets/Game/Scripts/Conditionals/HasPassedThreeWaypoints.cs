using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class HasPassedThreeWaypoints : Conditional
{
    CastleGuard castleGuard;

    public override void OnStart()
    {
        // Initialize
        castleGuard = GetComponent<CastleGuard>();
    }

    public override TaskStatus OnUpdate()
	{
        // If the castle guard has already passed 3 or more way points
        if (castleGuard.passedWaypointCount >= 3)
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