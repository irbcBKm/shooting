using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : NetworkBehaviour 
{
    NetworkVariable <float> gametime = new NetworkVariable<float>(60f);
    public NetworkVariable<bool> GameEnd = new NetworkVariable<bool>(false);
    public Text timeText;
    public bool Lose = false;
    
    public bool PlayTime = false;
    [SerializeField]
    private Button TimerSteartButton;
    private void Start() {
        TimerSteartButton.onClick.AddListener(() => Timerstart());
    }
    public override void OnNetworkSpawn()
    {
        
    }
    void Update()
    {
        timeText.text = gametime.Value.ToString("F2");
        if (gametime.Value <= 0 || GameEnd.Value)
        {
            Gameover();
        }
        if (!IsServer)return;
        if(!PlayTime)return;
        gametime.Value -= Time.deltaTime;
    }
    void Timerstart(){
        gametime.Value = 60f;
        PlayTime = true;
        TimerSteartButton.interactable = false;
    }
    public void Loser(){
        Lose = true;
        GameEnd.Value = true;
    }
    public void Gameover(){
        SceneManager.LoadScene("ResultSeen");
    }
}