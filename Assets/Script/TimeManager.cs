using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class TimeManager : NetworkBehaviour 
{
    NetworkVariable <float> gametime = new NetworkVariable<float>(60f);
    public Text timeText;
    
    public bool PlayTime;
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
        if (!IsServer)return;
        if(!PlayTime)return;
        gametime.Value -= Time.deltaTime;
        if (gametime.Value <= 0)
        {
            PlayTime = false;
        }
    }
    void Timerstart(){
        gametime.Value = 60f;
        PlayTime = true;
        TimerSteartButton.interactable = false;
    }
}