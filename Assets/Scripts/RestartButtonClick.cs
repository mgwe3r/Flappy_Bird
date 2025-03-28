using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButtonClick : MonoBehaviour
{

    private Button _button;
    private Bird _bird;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        _bird = GameObject.Find("Bird").GetComponent<Bird>();
        _button = GetComponent<Button>();
        _button.onClick.AddListener(RestartButton);

    }

    public void RestartButton()
    {
        _bird.ResetGame();
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
