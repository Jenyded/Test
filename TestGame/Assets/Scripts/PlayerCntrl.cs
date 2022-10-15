using UnityEngine;

public class PlayerCntrl : MonoBehaviour
{
    public float speed = 5f;
   
    private Rigidbody _rb;

    public TextMesh scoreText;

    private int _score = 0;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rb.AddForce(new Vector3(h, 1, v) * speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "CollectiveCube")
        {
            _score++;
            Destroy(other.gameObject);
            if(_score != 5)
                scoreText.text = "Score: " + _score;
            else
                scoreText.text = "You win! ";
        }

    }
}
