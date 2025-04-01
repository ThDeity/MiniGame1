using UnityEngine;

public class Platform : MonoBehaviour
{
    private Vector2 _velocity;
    private Rigidbody2D _rigidbody2D;
    public float speed;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _velocity = new Vector2(Input.GetAxis("Horizontal"), 0).normalized;
        _rigidbody2D.velocity = _velocity * speed;
    }
}
