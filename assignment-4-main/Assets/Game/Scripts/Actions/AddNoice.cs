using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class AddNoice : Action
{
    CastleGuard castleGuard;

	public override void OnStart()
	{
        // Initialize
        castleGuard = GetComponent<CastleGuard>();
	}

	public override TaskStatus OnUpdate()
    {
        // Initialize
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Send a ray to where the curser currently at
        if (Physics.Raycast(ray, out hit, 100))
        {
            // Add that point to the pointsOfInterest list
            castleGuard.pointsOfInterest.Add(new Vector3(hit.point.x, castleGuard.transform.position.y, hit.point.z));
        }

        // Return success
        return TaskStatus.Success;
	}
}