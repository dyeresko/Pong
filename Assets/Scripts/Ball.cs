using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] float speed = 200.0f;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void AddStartingForce()
    {
        float x = Random.value > 0.5f ? -1.0f : 1.0f;
        float y = Random.value > 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 _direction = new Vector2(x, y);
        _rigidbody.AddForce(_direction * speed);
    }


    public void AddForce(Vector2 dirForce)
    {
        _rigidbody.AddForce(dirForce);
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }
}
