using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class TimeManager : NetworkBehaviour 
{
    NetworkVariable<float> gametime;
    [SerializeField]
    private Text timeText;
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
        if(!PlayTime)return;
        
    }
    void Timerstart(){
        //gametime = 60f;
        PlayTime = true;
        TimerSteartButton.interactable = false;
    }
}