using UnityEngine;
using UnityEngine.UI;

public class Circle : MonoBehaviour
{
    protected Vector2 _velocity;
    protected Rigidbody2D _rigidbody2D;
    [SerializeField] protected Text _counter;
    [SerializeField] protected float _speed, _speedBuff;

    int _count;

    protected virtual void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _velocity = -transform.up;
    }

    protected virtual void FixedUpdate() => _rigidbody2D.velocity = _velocity * _speed;

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            _count++;
            if (_count % 3 == 0)
                _speed *= _speedBuff;

            _counter.text = _count.ToString();
        }

        _velocity = Vector2.Reflect(_velocity.normalized, collision.contacts[0].normal).normalized;
    }
}
