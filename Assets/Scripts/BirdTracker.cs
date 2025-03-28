using UnityEngine;

public class BirdTracker : MonoBehaviour
{

    private GameObject _bird;
    public float xOffset = -1;

    // Start is called before the first frame update
    void Start()
    {
        _bird = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_bird.transform.position.x - xOffset, transform.position.y, transform.position.z);
    }


}
