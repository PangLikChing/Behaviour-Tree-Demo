using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugGizmos : MonoBehaviour
{
    [SerializeField] CastleGuard castleguard;

    private void OnDrawGizmos()
    {
        // For every point in pointsOfInterest
        for (int i = 0; i < castleguard.pointsOfInterest.Count; i++)
        {
            // Draw them out in gizmos
            DebugExtension.DrawCircle(castleguard.pointsOfInterest[i], 1);
        }
    }
}
