using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab;
    private Transform _spawnPosition;

    [SerializeField] private float _startDelay = 2f;
    [SerializeField] private float _repietRate = 1.0f;

   
    // Start is called before the first frame update
    private void Start()
    {
        _spawnPosition = GetComponent<Transform>();
        InvokeRepeating("SpawnObstacle", _startDelay, _repietRate);
    }

    private void SpawnObstacle()
    {
        _spawnPosition.position = new Vector3(_spawnPosition.position.x, Random.Range(-2.2f, 0.5f));
        Instantiate(_pipePrefab, _spawnPosition.position, _spawnPosition.transform.rotation);
    }


}
