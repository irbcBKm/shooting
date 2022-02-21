using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ResultText;
    public void GoStart()
    {
        SceneManager.LoadScene("StartMenu");
    }
    void Start()
    {
        var ResultView= GetComponent<ResultManager>();
        switch (ResultView.result)
        {
            case 1:
            ResultText.text = "lose";
            break;
            case 2:
            ResultText.text = "draw";
            break;
            default:
            ResultText.text = "Win";
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
