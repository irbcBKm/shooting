using UnityEngine;
using Unity.Netcode;

public class PlayerHealthController : NetworkBehaviour {
    
    public NetworkVariable<float> HealthNetVar{get;} = new NetworkVariable<float>(DefaultHealth);

    public float Health{
        get => HealthNetVar.Value;
        set => HealthNetVar.Value = value;
    }
    public const float DefaultHealth = 100;
    public float MaxHealth{get;}= DefaultHealth;
    #region Server Side
    public void TakeDamage(float value){
        var health = Health - value;
        Health = Mathf.Max(0f,health);
        if(health <= 0){
            var losePlayer = GetComponent<TimeManager>();
            losePlayer.Loser();
        }
    }
    #endregion
}