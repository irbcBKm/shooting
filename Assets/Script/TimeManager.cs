using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : NetworkBehaviour 
{
    NetworkVariable <float> gametime = new NetworkVariable<float>(60f);//制限時間
    public NetworkVariable<bool> GameEnd = new NetworkVariable<bool>(false);//時間切れ以外でゲームを終了するときに使用
    public Text timeText;//制限時間表示用
    
    public bool PlayTime = false;//タイマーの作動、停止管理用フラグ
    [SerializeField]
    private Button TimerSteartButton;//タイマーの作動開始ボタン
    private void Start() {
        TimerSteartButton.onClick.AddListener(() => Timerstart());
    }
    public override void OnNetworkSpawn()
    {
        
    }
    void Update()
    {
        timeText.text = gametime.Value.ToString("F2");
        if (gametime.Value <= 0)
        {
            /*var resultcontll = GetComponent<ResultManager>();
            resultcontll.draw();*/
            Gameover();
        }
        if(GameEnd.Value){
            Gameover();
        }
        if (!IsServer)return;
        if(!PlayTime)return;
        gametime.Value -= Time.deltaTime;
    }
    void Timerstart(){
        //if(!IsServer)return;
        gametime.Value = 60f;
        PlayTime = true;
        TimerSteartButton.interactable = false;
    }
    
    public void Gameover(){
        SceneManager.LoadScene("ResultSeen");
    }
    [ServerRpc]
    public void GameEnderServerRpc(){
        GameEnd.Value = true;
    }
}