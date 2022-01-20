using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public Text timeText;
    public float gametime = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gametime -= Time.deltaTime;
        timeText.text = gametime.ToString("F2");
        if (gametime <= 0)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        SceneManager.LoadScene("ResultSeen");
    }
}
