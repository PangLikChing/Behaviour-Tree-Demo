using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;

public class StopMoving : Action
{
	NavMeshAgent navMeshAgent;
	public override void OnStart()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
	}

	public override TaskStatus OnUpdate()
	{
		navMeshAgent.ResetPath();
		return TaskStatus.Success;
	}
}