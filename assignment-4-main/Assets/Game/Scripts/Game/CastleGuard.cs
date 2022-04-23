using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CastleGuard : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    readonly int SpeedParameter = Animator.StringToHash("Speed");
    public Transform waypoints;
    public float turnDistance = 1f;
    public List<Vector3> pointsOfInterest = new List<Vector3>();
    public int passedWaypointCount = -1;
    public int maxPointsOfInterest = 5;
    public Vector3 patrolDestination, investigationDestination;
    public int health = 3;
    public bool isDead = false;

    [HideInInspector] public int nextWaypoint = -1;
    [HideInInspector] public Animator animator;

    void Start()
    {
        // Initialize
        isDead = false;
        health = 3;
        nextWaypoint = 0;
        passedWaypointCount = -1;
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        patrolDestination = transform.position;
    }

    void Update()
    {
        // If the guard's health is less than 0
        if (health <= 0)
        {
            // Set isDead to true
            isDead = true;

            // Do not update anything else
            return;
        }

        // Update speed of gameObject
        float speed = Vector3.Project(navMeshAgent.desiredVelocity, transform.forward).magnitude * navMeshAgent.speed;
        animator.SetFloat(SpeedParameter, speed);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
