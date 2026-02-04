using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist > 5)
        {
            agent.SetDestination(player.position);
            GetComponent<Animator>().SetBool("Attack", false);
        }
        else
        {
            transform.LookAt(new Vector3(player.position.x, transform.position.y, transform.position.z));
            GetComponent<Animator>().SetBool("Attack", true);
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
