using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    Rigidbody2D rigid;
    public float maxspeed = 5;
    public float speed = 5;
    public float jumppower ;
    SpriteRenderer sprite;
    Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump")&& !anim.GetBool("jump"))
        {
            rigid.AddForce(Vector2.up * jumppower, ForceMode2D.Impulse);
            anim.SetBool("jump", true);
        }
        
           

        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }
        if (Input.GetButtonDown("Horizontal"))
            sprite.flipX = Input.GetAxisRaw("Horizontal") == -1;

        if (Mathf.Abs( rigid.velocity.x) < 0.3)
            anim.SetBool("walk", false);
        else
            anim.SetBool("walk", true);

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        
        if (rigid.velocity.x > maxspeed)
            rigid.velocity = new Vector2(maxspeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxspeed*(-1))
            rigid.velocity = new Vector2(maxspeed*(-1), rigid.velocity.y);

        if (rigid.velocity.y < 0) {
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.9f)
                    anim.SetBool("jump", false);
            }
        }
        

    }

}
