using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hooking : MonoBehaviour
{
    // Start is called before the first frame update
    grapplinghook grab;
    public DistanceJoint2D joint2D;
    void Start()
    {
        grab = GameObject.Find("Player").GetComponent<grapplinghook>();
        joint2D = GetComponent<DistanceJoint2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ring"))
        {
            joint2D.enabled = true;
            grab.isAttatch = true;
        }
    }
}
