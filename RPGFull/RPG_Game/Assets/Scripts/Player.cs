using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region playercontroll

    [Header("Animation_parameter_name")]
    public string parRun = "RunSwitch";
    public string parJump = "JumpSwitch";
    public string parAttack = "AttackSwitch";
    public string parDead = "DeadSwitch";

    [Header("Props")]
    public int countNeed = 10;
    public int countCurrent;

    [Header("Character")]
    public bool isDead;
    [Range(0, 500)]
    public float hp = 100;

    #endregion

    public Transform character;
    public Animator animator;

    #region playermethod
    /// <summary>
    /// 跑步
    /// </summary>
    void Run()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        // print(animator.GetCurrentAnimatorStateInfo(0).IsName("run"));
        // animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1
        
        animator.SetBool("run", v != 0 || h != 0);        
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    void Jump()
    {
        animator.SetBool("jump", Input.GetKey(KeyCode.Space));
    }

    /// <summary>
    /// 攻擊
    /// </summary>
    void Attack()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            print("攻擊");
            animator.SetTrigger("attack");
        }
    }

    /// <summary>
    /// 獲得道具
    /// </summary>
    void GetProp()
    {

    }

    /// <summary>
    /// 受到傷害
    /// </summary>
    /// <param name="damage"></param>
    void Damage(float damage)
    {

    }

    /// <summary>
    /// 過關
    /// </summary>
    void Pass()
    {
        
    }

    /// <summary>
    /// 死亡
    /// </summary>
    void Dead()
    {

    }
    #endregion

    void Update()
    {
        Run();
        Jump();
        Attack();
    }
}
