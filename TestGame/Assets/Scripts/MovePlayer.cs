using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;
    public float hSpeed = 10f, _thrust = 500f;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y, v));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Block")
            _rb.AddForce(new Vector3(0, 1, 0) * _thrust);
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.name == "Block")
            Debug.Log("Контакт");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Контакт прекращен");
    }
}

