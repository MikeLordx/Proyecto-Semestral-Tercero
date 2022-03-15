using UnityEngine;
using Pathfinding;

public class EnemyPathfinding : MonoBehaviour
{
    public Transform targetPosition;

    public void Start()
    {
        Seeker seeker = GetComponent<Seeker>();
        seeker.StartPath(transform.position, targetPosition.position);
    }
}
