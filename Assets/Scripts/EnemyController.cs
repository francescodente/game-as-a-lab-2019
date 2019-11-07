using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float pathUpdateRate = 4;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(UpdateDestination());
    }

    private IEnumerator UpdateDestination()
    {
        WaitForSeconds wait = new WaitForSeconds(1 / pathUpdateRate);
        while (target != null)
        {
            agent.SetDestination(target.position);
            yield return wait;
        }
    }
}
