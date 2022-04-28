using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public float velocity = 10;
    
    public Rigidbody2D _Rigidbody2D;
    private SpriteRenderer _renderer;

    private PlayerController _playerController;
    

    
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _Rigidbody2D.velocity =new Vector2(velocity, _Rigidbody2D.velocity.y);
        
        Destroy(this.gameObject, 5);
    }
    public void SetController(PlayerController playerController)
    {
        _playerController = playerController;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        var tag = col.gameObject.tag;
        
        
        if (tag=="enemy")
        {
            Destroy(this.gameObject);
            /*xp += 1;
            Debug.Log(xp);
            if (xp==5)
            {
                Destroy(col.gameObject);
            }
            */
           

        }
    }
}
