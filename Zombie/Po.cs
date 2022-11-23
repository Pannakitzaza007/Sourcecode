using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Po : MonoBehaviour
{
    public Transform me;
    private UnityEngine.AI.NavMeshAgent enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(me.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }

}