using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 forward = Vector3.zero;
    public float Speed = 10;
    public float timeLimit = 0;

    void Update()
    {
        // 按照速度向前向飞行
        transform.position += forward * Speed * Time.deltaTime;
        timeLimit += Time.deltaTime;
        if (timeLimit > 2)
        { Destroy(gameObject); }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<RoleCtrl>();
        if (player == null) Destroy(gameObject);
    }
}
