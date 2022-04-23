using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class ToNextWaypoint : Action
{
	CastleGuard castleGuard;
	NavMeshAgent navMeshAgent;

	public override void OnStart()
	{
		// Initialize
		castleGuard = GetComponent<CastleGuard>();
		navMeshAgent = GetComponent<NavMeshAgent>();
	}

	public override TaskStatus OnUpdate()
	{
		// Cache the waypoints
		Transform waypoints = castleGuard.waypoints;

		// Throw a debug message
		Debug.Log($"Going to {waypoints.GetChild(castleGuard.nextWaypoint).gameObject.name}");

		// Set destination to next waypoint
		navMeshAgent.SetDestination(waypoints.GetChild(castleGuard.nextWaypoint).position);

		// Save the next waypoint as patrolDestination
		castleGuard.patrolDestination = waypoints.GetChild(castleGuard.nextWaypoint).position;

		// If the agent has reached the end
		if (castleGuard.nextWaypoint == waypoints.childCount - 1)
		{
			// Reset nextWaypoint
			castleGuard.nextWaypoint = 0;
		}

		return TaskStatus.Success;
	}
}