using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _bestScoreLabel;
    [SerializeField]
    private ScoreController _scoreController;

    [SerializeField]
    private TextMeshProUGUI _currentScoreLabel;


    public void OnEnable()
    {
        _currentScoreLabel.text = _scoreController.GetCurrentScore().ToString();
        _bestScoreLabel.text = $"BEST {_scoreController.GetBestScore().ToString()}";
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
