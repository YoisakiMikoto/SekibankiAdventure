using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class headCtrl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rg;
    public bool start;
    SpriteRenderer spriterenderer;
    SkillSaver skillSaver;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        skillSaver = FindObjectOfType<SkillSaver>();
    }
    private void OnEnable()
    {
        start = false;
        // spriterenderer.color = Color.white;
    }
    // Update is called once per frame
    void Update()
    {
        if (start && skillSaver.canHeadMove)
        {
            float h = Input.GetAxis("Horizontal");
            float v = rg.velocity.y;
            var vector = new Vector2(h * speed, v);
            rg.velocity = vector;
            if (h != 0)
            {
                transform.localScale = new Vector3(h > 0 ? 1 : -1, 1, 1);
            }
        }
        if (rg.velocity.x != 0)
        {
            transform.localScale = new Vector3(rg.velocity.x > 0 ? 1 : -1, 1, 1);
        }
        spriterenderer.color = Vector4.Lerp(spriterenderer.color, Color.red, Time.deltaTime * 0.2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        start = true;
    }
}
