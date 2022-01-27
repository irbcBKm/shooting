using UnityEngine;
using Unity.Netcode;

public class ShotBullet : NetworkBehaviour 
{
    [SerializeField]//インスペクターへの表示
    private GameObject m_bullet;
    [SerializeField]//インスペクターへの表示
    private Transform m_shotPoint;

    // Update is called once per frame
    void Update()
    {
        if(!IsOwner)return;
        if (Input.GetKeyDown(KeyCode.Z)||Input.GetKeyDown(KeyCode.Space))
        {
            ShotServerRpc();
        }
    }
    [ServerRpc]
    private void ShotServerRpc(ServerRpcParams rpcParams = default)
    {
        var bullet = Instantiate(m_bullet,m_shotPoint.position,m_shotPoint.rotation);

        bullet.GetComponent<NetworkObject>().SpawnWithOwnership(rpcParams.Receive.SenderClientId);
        bullet.GetComponent<Rigidbody>().velocity = 20f * m_shotPoint.forward;
    }
}
