using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private TMP_Text _score;

    public void ScoreChanger(int score)
    {
        _score.text = score.ToString();
    }
}
