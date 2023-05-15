using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class RoleCtrl : MonoBehaviour
{
    public bool Freeze;
    public float speed;
    public float jumpingPower;
    private Rigidbody2D rg;
    public bool Isrunning;
    public GameObject Leg;
    public GameObject Body;
    private Animator animator;
    public Transform CheckGroundPoint;
    public LayerMask CheckLayerMask;
    public LayerMask CheckHead;
    public bool IsJumping;
    public Transform WallCheckPoint1;
    public Transform WallCheckPoint2;
    public bool canJump;
    bool IsWall;
    bool help;
    float latejumptimer;
    public Transform jumphelp;
    // StarGameObject CheckGroundWall;t is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        animator = Leg.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if (Freeze)
        {
            h=0;
            animator.SetBool("Isrunning",false);
        }
        float v = rg.velocity.y;

        //for tolerance about jump
        if (IsJumping == false)
        {
            canJump = true;
            latejumptimer = 0;
            help = true;
        }
        else if (!IsWall && help)
        {
            var collider = Physics2D.OverlapBox(new Vector2(jumphelp.position.x, jumphelp.position.y), new Vector2(0.3f, 0.2f), 0f, CheckLayerMask);
            if (collider != null)
            {
                v = 0.8f;
                help = false;
            }
        }
        rg.velocity = new Vector2(h* speed, v) ;
        if (canJump)
        {
            latejumptimer += Time.deltaTime;
            if (latejumptimer > 0.1)
            {
                canJump = false;
            }//latejumptime
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rg.velocity = new Vector2(rg.velocity.x, jumpingPower);
            }//jump
        }
        if (Input.GetKeyUp(KeyCode.Space) && rg.velocity.y > 0f)
        {
            rg.velocity = new Vector2(rg.velocity.x, rg.velocity.y * 0.5f);
        }//littleJump

        if (h != 0)
        {
            Body.transform.localScale = new Vector3(h > 0 ? 1 : -1, 1, 1);
        }
        if (h != 0 && IsJumping == false)
            Isrunning = true;
        else Isrunning = false;
            animator.SetBool("Isrunning", Isrunning);

    }
    private void FixedUpdate()
    {
        // 通过对地面的检查进行处理
        var collider = Physics2D.OverlapCircle(CheckGroundPoint.position, 0.2f, CheckLayerMask);
        // 计算碰撞体
        IsJumping = collider == null;
        if (IsJumping)
        {
            var colliderhead = Physics2D.OverlapCircle(CheckGroundPoint.position, 0.2f, CheckHead);
            IsJumping = colliderhead == null;
        }
        // 如果是跳跃状态
        var collider1 = Physics2D.OverlapCircle(WallCheckPoint1.position, 0.2f, CheckLayerMask);
        var collider2 = Physics2D.OverlapCircle(WallCheckPoint2.position, 0.2f, CheckLayerMask);
        if (collider1 != null || collider2 != null)
        {
            IsWall = true;
            rg.velocity = new Vector2(0, rg.velocity.y);
        }
        else
            IsWall = false;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(jumphelp.position, new Vector2(0.3f, 0.2f));
    }
}
