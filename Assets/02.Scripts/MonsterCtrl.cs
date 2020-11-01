using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterCtrl : MonoBehaviour
{
    private Transform monsterTr;
    private Transform playerTr;

    private NavMeshAgent agent;
    private Animator anim;
    
    void Start()
    {
        monsterTr = GetComponent<Transform>();
        playerTr = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        anim  = GetComponent<Animator>();

        agent.SetDestination(playerTr.position);
        anim.SetBool("IsTrace", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(monsterTr.position, playerTr.position) <= 2.0f)
        {
            agent.isStopped = true;
            anim.SetBool("IsAttack", true);
        }
        else
        {
            agent.isStopped = false;
            agent.SetDestination(playerTr.position);
            anim.SetBool("IsAttack", false);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("BULLET"))
        {
            Destroy(coll.gameObject);
            
        }
    }
}
