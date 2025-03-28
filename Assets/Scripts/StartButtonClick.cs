using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartButtonClick : MonoBehaviour
{
    private Button _button;
    private Bird _bird;
    [SerializeField] private GameObject _startScreen;
    [SerializeField] private TMP_Text _startText;

    // Start is called before the first frame update
    void Start()
    {
        _bird = GameObject.Find("Bird").GetComponent<Bird>();
        _button = GetComponent<Button>();
        _button.onClick.AddListener(StartButton);
    }

    public void StartButton()
    {
        _bird.ResetGame();
        _startScreen.SetActive(false);
        _startText.text = "";
    }
}
