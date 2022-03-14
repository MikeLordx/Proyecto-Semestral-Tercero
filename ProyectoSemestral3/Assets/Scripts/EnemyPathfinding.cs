using UnityEngine;
using Pathfinding;

public class EnemyPathfinding : MonoBehaviour
{
    public Transform targetPosition;

    public void Start()
    {
        Seeker seeker = GetComponent<Seeker>();
        seeker.StartPath(transform.position, targetPosition.position, OnPathComplete);
    }

    public void OnPathComplete(Path p)
    {
        Debug.Log("Yay, we got a path back. Did it have an error? " + p.error);
    }
}
