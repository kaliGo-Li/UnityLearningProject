using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public bool gameOver = false;
    public Transform gameOverText;
    public Transform hintText;

    private void Awake()
    {
        instance = this;
        GameObject parentObject = GameObject.Find("Canvas");
        gameOverText = parentObject.transform.Find("GameOverText");
        hintText = parentObject.transform.Find("HintText");
    }
    void Start()
    {
        
    }
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    public void OnBirdDied()
    {
        gameOver = true;
        gameOverText.gameObject.SetActive(true);
        hintText.gameObject.SetActive(true);
    }
}
