using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class IsSecondWaypoint : Conditional
{
    CastleGuard castleGuard;

    public override void OnStart()
    {
        // Initialize
        castleGuard = GetComponent<CastleGuard>();
    }

    public override TaskStatus OnUpdate()
    {
        // If the castle guard has already passed 2
        if (castleGuard.passedWaypointCount == 2)
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