using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform attackPoint;
    public Animator playerAnim;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            PlayerAttack();
        }
    }

    private void PlayerAttack()
    {
        playerAnim.SetBool("Attack", true);

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemies in hitEnemies)
        {
            enemies.GetComponent<EnemyBehavior>().Hit();
        }

        StartCoroutine(PlayerAttackAnim());
    }

    private IEnumerator PlayerAttackAnim()
    {
        yield return new WaitForSeconds(0.5f);

        playerAnim.SetBool("Attack", false);
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
