using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitandRun : MonoBehaviour
{
    public GameManager gm;

    Animator animator;
    public GameObject player;
    float PlayerDis;
    public bool Dead = false;
    bool Attacking = false;

    private float Targetx;
    private float Targetz;
    private float Currentx;
    private float Currentz;


    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        PlayerDis = Vector3.Distance(transform.position, player.transform.position);
        animator.SetFloat("PDist", PlayerDis);

        Targetx = player.transform.position.x;
        Targetz = player.transform.position.z;

        Vector3 Target = new Vector3(Targetx, 0, Targetz);

        Currentx = transform.position.x;
        Currentz = transform.position.z;

        Vector3 Current = new Vector3(Currentx, 0, Currentz);

        
        if (Dead == true)
        {

        }
        if (PlayerDis <= 6 && Dead == false)
        {
            transform.LookAt(player.transform.position);
            transform.position = Vector3.MoveTowards(Current, Target, 0.005f);
        }


        if (PlayerDis <= 2 & Dead == false)
        {
            animator.SetBool("Attacking", true);
            Attacking = true;

        }
        else
        {
            animator.SetBool("Attacking", false);
            Attacking = false;

        }

    }

    
    void OnCollisionEnter(Collision Col)
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();


        if (Col.gameObject.name == "45ACP Bullet_Head(Clone)")    // Collision Test for Enemies and Bullets
        {
            Dead = true;
            gm.EnemiesDead++;
            animator.SetBool("Dead", true);
            transform.Translate(0, -0.8f, 0);
        }  
        
        if ((Col.gameObject.name == "Male_01_V02") && (Dead == false) && (PlayerDis < 2) && (Attacking == true))    // Collision Test for Enemies and Player
        {
            gm.EnemyAttack();
        }
    }


}
