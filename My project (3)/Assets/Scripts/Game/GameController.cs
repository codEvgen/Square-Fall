using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private SquareSpawner _squareSpawner;
    [SerializeField]
    private GameObject _gameStartScreen;
    [SerializeField]
    private GameObject _gameScreen;
    [SerializeField]
    private GameObject _gameOverScreen;

    [SerializeField]
    private float _gameOverScreenShowDelay; //задержка до появления экрана окончания игры

    private bool _wasGameOver;
    
    public void StartGame()
    {
        _gameStartScreen.SetActive(false);
        _gameScreen.SetActive(true);
    }
    public void RestartGame()
    {
        var sceneName = SceneManager.GetActiveScene().name; //получаем название сцены
        SceneManager.LoadSceneAsync(sceneName); //загружаем данную сцену
    }
    public void OnPlayerDied()
    {
        _wasGameOver = true;
        _squareSpawner.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_wasGameOver)
        {
            _gameOverScreenShowDelay -= Time.deltaTime;

            if (_gameOverScreenShowDelay <= 0)
            {
                ShowGameOverScreen();
            }
        }
    }
    private void ShowGameOverScreen()
    {
        _gameScreen.SetActive(false);
        _gameOverScreen.SetActive(true);
    }
    private void Awake()
    {
        Application.targetFrameRate = 60;//максимальное значение кадров в секунду

        _gameScreen.SetActive(false);
        _gameOverScreen.SetActive(false);
        _gameStartScreen.SetActive(true);
    }
}
