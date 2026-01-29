using System.Collections;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        if (scoreText == null) 
        scoreText = GetComponent<TMP_Text>();
    }

    private IEnumerator Start()
    {
        while (GameController.Instance == null)
        yield return null;

        GameController.Instance.OnScoreChanged += HandleScoreChanged;
        HandleScoreChanged(0);
    }

    private void OnDestroy()
    {
        if (GameController.Instance != null)
        GameController.Instance.OnScoreChanged -= HandleScoreChanged;
    }

    private void HandleScoreChanged(int score)
    {
        scoreText.text = score.ToString();
    }
}
