using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    protected Rigidbody2D _rigidbody;
    protected float speed = 10.0f;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0);
        _rigidbody.velocity = Vector2.zero;
    }

}
