using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    private enemy enemyMovement;
    private Transform player;
    public float attackRange = 3f;


    private enemy enemyScript;

    public Material defaultMaterial;
    public Material allertMaterial;
    public Renderer ren;

    private bool foundPlayer;

    // Start is called before the first frame update

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyMovement = GetComponent<enemy>();
        ren = GetComponent<Renderer>();
    }




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            ren.sharedMaterial = allertMaterial;
            enemyMovement.badGuy.SetDestination(player.position);
            foundPlayer = true;
        }
        else if (foundPlayer)
        {
            ren.sharedMaterial = defaultMaterial;
            enemyMovement.newLocation();
            foundPlayer = false;
        }
    }
}