using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearChest : MonoBehaviour
{
    Animator anim;
    public bool near;
    public int status = 0;
    void Start()
    {
        anim = GetComponent<Animator>();
        near = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (near)
        {
            anim.SetBool("Near", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        near = true;
        status = 1;
    }

}
