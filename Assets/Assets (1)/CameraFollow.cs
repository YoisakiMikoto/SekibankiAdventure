using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using static UnityEditor.Experimental.GraphView.GraphView;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    RoleSkill setting;
    public Transform targetRole;
    public Transform targetHead;
    public float speed;
    public Vector3 target;
    //mapBorder
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    //backGround
    public Transform basicLayer;
    public Transform layer1;
    public Transform layer2;
    public Transform layer3;
    public Transform layer4;
    public Transform layerCover;

    public float ratelayer1;//0~1
    public float ratelayer2;//smaller
    public float ratelayer3;//smaller
    public float ratelayer4;//smaller

    float x;
    float y;
    // Start is called before the first frame update
    void OnEnable()
    {
        setting = player.GetComponent<RoleSkill>();
        targetRole = GameObject.FindGameObjectWithTag("Player").transform;
        targetHead = GameObject.FindGameObjectWithTag("head").transform;
        //layer
        layer1.localScale = basicLayer.localScale + (layerCover.localScale - basicLayer.localScale) * ratelayer1;
        layer2.localScale = basicLayer.localScale + (layerCover.localScale - basicLayer.localScale) * ratelayer2;
        layer3.localScale = basicLayer.localScale + (layerCover.localScale - basicLayer.localScale) * ratelayer3;
        layer4.localScale = basicLayer.localScale + (layerCover.localScale - basicLayer.localScale) * ratelayer4;
    }

    // Update is called once per frame
    void Update()
    {
        if (setting.IsSetting)
        {
            target.x = Mathf.Clamp(targetHead.position.x, minX, maxX);
            target.y = Mathf.Clamp(targetHead.position.y, minY, maxY);
        }
        else
        {
            target.x = Mathf.Clamp(targetRole.position.x, minX, maxX);
            target.y = Mathf.Clamp(targetRole.position.y, minY, maxY);
        }
        target.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, target+new Vector3(0,1,0), Time.deltaTime * speed);
    }
    private void LateUpdate()
    {
        x = layerCover.position.x - transform.position.x;
        y = layerCover.position.y - transform.position.y;
        basicLayer.position = new Vector3(transform.position.x, transform.position.y, basicLayer.position.z);
        //layer1
        layer1.position = new Vector3(transform.position.x + x * ratelayer1, transform.position.y + y * ratelayer1, layer1.position.z);
        //layer2
        layer2.position = new Vector3(transform.position.x + x * ratelayer2, transform.position.y + y * ratelayer2, layer2.position.z);
        //layer3
        layer3.position = new Vector3(transform.position.x + x * ratelayer3, transform.position.y + y * ratelayer3, layer3.position.z);
        //layer4
        layer4.position = new Vector3(transform.position.x + x * ratelayer4, transform.position.y + y * ratelayer4, layer4.position.z);
    }
}
