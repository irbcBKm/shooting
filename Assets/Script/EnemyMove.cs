using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    public GameObject target;
    void Start()
    {
        //this.transform.position(0, 1, -10);
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
}
