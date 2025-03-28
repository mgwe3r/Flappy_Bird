using UnityEngine;

public class BirdMover1 : MonoBehaviour
{
    public Vector3 startPosition;
    public float tapForce = 500;
    public int speed = 5;
    public float rotationSpeed = 20;
    public float maxRotationZ = 180;
    public float minRotationZ = -180;

    private Rigidbody2D _rb;
    private Bird _bird;
    private Quaternion _maxRotation;
    private Quaternion _minRotation;

    // Start is called before the first frame update
    void Start()
    {    
        _rb = GetComponent<Rigidbody2D>();
        _bird = GameObject.Find("Bird").GetComponent<Bird>();
        ResetBird();

        _maxRotation = Quaternion.Euler(0,0, maxRotationZ);
        _minRotation = Quaternion.Euler(0,0, minRotationZ);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _bird.isGameActive) 
        {
            _rb.velocity = new Vector2(speed, 0);
            transform.rotation = _maxRotation;
            _rb.AddForce(Vector3.up * tapForce, ForceMode2D.Force);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, rotationSpeed * Time.deltaTime);
    }
    public void ResetBird()
    {
        transform.position = startPosition;
        transform.rotation =  Quaternion.Euler(0,0,0);
        _rb.velocity = Vector2.zero;
    }
}
