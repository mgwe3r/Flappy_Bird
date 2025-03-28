using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private Transform _mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= _mainCamera.position.x - 10)
        {
            Destroy(gameObject);
        }
    }
}
