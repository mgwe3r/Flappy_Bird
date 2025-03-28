using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private GameObject _overScreen;

    private BirdMover1 _mover;
    [SerializeField] private int _score;
    [SerializeField] private Score _scoreChanger;

    public bool isGameActive = true;

    // Start is called before the first frame update
    void Start()
    {
        _overScreen.gameObject.SetActive(false);
        _mover = GetComponent<BirdMover1>();
        Time.timeScale = 0;
        isGameActive = false;
    }

    public void IncreaseScore()
    {
        _score++;
        _scoreChanger.ScoreChanger(_score);
    }

    public void ResetGame()
    {
        _score = 0;
        _mover.ResetBird();
        Time.timeScale = 1;
        isGameActive = true;
    }

    public void Loss()
    {
        _overScreen.gameObject.SetActive(true);
        Debug.Log("I am a loss");
        Time.timeScale = 0;
        isGameActive = false;
    }


}
