using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleSkill : MonoBehaviour
{
    float cd;
    bool incd;
    public int Key=0;
    public int KeyNeed;
    public GameObject headOnUsing;//
    public bool IsUsing;
    public GameObject head;//
    public GameObject body;
    public GameObject Bullet;
    public GameObject Ring;
    public CircleCollider2D headCollider;
    public Rigidbody2D bodyrg;
    public float force=10;
    public float For=3;
    public GameObject headPrefab;
    public RoleCtrl RcPlayer;
    public float timer;
    public float clearHeadCD = 5;
    public bool IsSetting;
    spaceCheck space;//spaceCheck
    public spaceCheck spaceUp;
    public spaceCheck spaceDown;
    //skillUnlock
    public SkillSaver skillSaver;

    private void Shoot()
    {
        // 实例化一个预制体或复制目标
        var clone = Instantiate(Bullet);
        // 从克隆体中获得子弹的脚本
        var bullet = clone.GetComponent<Bullet>();
        // 根据发射方向调整子弹的方向
        bullet.transform.rotation = Ring.transform.rotation;
        // 飞行前向向量指定，这是一个四元数对向量相乘的计算
        bullet.forward = Ring.transform.rotation * Vector3.up;
        // 发射的位置点
        bullet.transform.position = Ring.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        cd=0;
        incd=false;
        headOnUsing.SetActive(false);
        head.SetActive(true);
        IsUsing = false;
        headCollider = GetComponent<CircleCollider2D>();
        headCollider.enabled = true;
        bodyrg = body.GetComponent<Rigidbody2D>();
        headPrefab.SetActive(false);
        Ring.SetActive(false);
        //skillUnlock
        skillSaver = FindObjectOfType<SkillSaver>();
    }
    public void getkey()
    {
        if (!incd)
        {
            Key++;
            incd=true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (incd) cd+=Time.deltaTime;
        if (cd>=0.5f)
        {
            cd=0;
            incd=false;
        }
        //sight ring
        if(skillSaver.canShoot)
            Ring.SetActive(true);
        Vector3 dest = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dest.z = 0;
        Vector3 v =Vector3.Normalize(dest - transform.position);
        Ring.transform.rotation = Quaternion.FromToRotation(Vector2.up, v);
        if (IsUsing)//head off
        {
            if (IsSetting)
            {
                timer += Time.deltaTime;
                if (timer > clearHeadCD || Input.GetKeyDown(KeyCode.E))
                {
                    IsSetting = false;
                    RcPlayer.enabled = true;
                    head.SetActive(true);
                    IsUsing = false;
                    headCollider.enabled = true;
                    headPrefab.SetActive(false);
                }//reset
                if (Input.GetMouseButtonDown(1) && space.spaceEmpty && skillSaver.canHeadTransfer)
                {
                    transform.position = new Vector3(headPrefab.transform.position.x, headPrefab.transform.position.y + 0.3f, transform.position.z);
                    IsSetting = false;
                    RcPlayer.enabled = true;
                    head.SetActive(true);
                    IsUsing = false;
                    headCollider.enabled = true;
                    headPrefab.SetActive(false);
                }//transfer
            }//disconnected
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    headOnUsing.SetActive(false); 
                    head.SetActive(true);
                    IsUsing = false;
                    headCollider.enabled = true;
                }//reset
                if (Input.GetMouseButtonDown(1) && (spaceUp.spaceEmpty || spaceDown.spaceEmpty))
                {
                    transform.position = new Vector3(body.transform.position.x, body.transform.position.y + 0.3f, transform.position.z);
                    headOnUsing.SetActive(false);
                    head.SetActive(true);
                    headCollider.enabled = true;
                    IsUsing = false;
                }//transfer
                if (Input.GetMouseButtonDown(0))
                {
                    Vector3 f =Vector3.Normalize(dest - body.transform.position);
                    f.z = 0;
                    bodyrg.AddForce(f * For, ForceMode2D.Impulse);
                }//HeadForce
                if (Input.GetKeyDown(KeyCode.F) && skillSaver.headThrow)
                {
                    headPrefab.SetActive(true);
                    headPrefab.transform.position = body.transform.position;
                    var Headtemprg = headPrefab.GetComponent<Rigidbody2D>();
                    Vector3 f = Vector3.Normalize(dest - headPrefab.transform.position);
                    f.z = 0;
                    Headtemprg.AddForce(f * force, ForceMode2D.Impulse);
                    space = headPrefab.GetComponentInChildren<spaceCheck>();
                    IsSetting = true;
                    timer = 0;
                    RcPlayer.enabled = false;
                    headOnUsing.SetActive(false);
                }//ThrowHead
                if (bodyrg.velocity.x != 0)
                {
                    body.transform.localScale = new Vector3(bodyrg.velocity.x > 0 ? 1 : -1, 1, 1);
                }
            }//connected
        }
        else//head on
        {
            if (Input.GetKeyDown(KeyCode.E) && skillSaver.headOff)
            {
                headOnUsing.SetActive(true);
                headCollider.enabled = false;
                body.transform.position = head.transform.position;
                head.SetActive(false);
                IsUsing = true;
            }//reset
            if (Input.GetMouseButtonDown(0) && skillSaver.canShoot)
            {
                Shoot();
            }//shoot
        }
    }
}
