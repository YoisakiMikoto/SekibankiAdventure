using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceCheck : MonoBehaviour
{
    public bool spaceEmpty;
    public LayerMask CheckLayerMask;
    // Start is called before the first frame update
    public Vector2 size = new Vector2(0.3f, 1);
    private void FixedUpdate()
    {
        var collider = Physics2D.OverlapBox(new Vector2(transform.position.x, transform.position.y), size, 0f,CheckLayerMask);
        if (collider == null)
        { spaceEmpty = true; }
        else { spaceEmpty = false; }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, size);
    }
}