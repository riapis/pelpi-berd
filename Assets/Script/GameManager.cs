 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    // Start is called before the first frame update
    private void Start()
    {
        gameOver.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void GameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
