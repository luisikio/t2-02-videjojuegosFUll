using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 5;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;

    private float cont = 0;
    private float cont2 = 0;
    private float cont3 = 0;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.velocity = new Vector2(-velocity, _rigidbody2D.velocity.y);
        _spriteRenderer.flipX = true;

    }

    

    private void OnTriggerEnter2D(Collider2D col)
    {
        var tag = col.gameObject.tag;

        if (tag=="bull")
        {
            cont += 1;
            Debug.Log(cont);
            if (cont==5)
            {
                Destroy(this.gameObject);
                cont = 0;
            }

        }
        if (tag=="bull2")
        {
            cont2 += 1;
            Debug.Log(cont);
            if (cont2==3)
            {
                Destroy(this.gameObject);
                cont2 = 0;
            }

        }
        if (tag=="bull3")
        {
            cont3 += 1;
            Debug.Log(cont);
            if (cont3==1)
            {
                Destroy(this.gameObject);
                cont3 = 0;
            }

        }
    }
}
