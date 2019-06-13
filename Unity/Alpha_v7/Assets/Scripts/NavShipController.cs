using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavShipController : MonoBehaviour {

	private NavMeshAgent agent;
    public List<GameObject> targets;
    private int currentTarget;

    private void Start()
    {
        agent = GetComponent(typeof(NavMeshAgent)) as NavMeshAgent;
        currentTarget = 0;
    }
    private void Update()
    {
        agent.SetDestination(targets[currentTarget].transform.position);
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == targets[currentTarget])
        {
            currentTarget = (currentTarget + 1) % targets.Capacity;
        }
    }
}
