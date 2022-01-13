using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

namespace Multiplay{
    
    public class M_GameManager : MonoBehaviour 
    {
        [SerializeField]
        private Button m_startHostButton;
        [SerializeField]
        private Button m_startClientButton;
        private void Start() {
            m_startHostButton.onClick.AddListener(() => HandleOnClickStartHostButton());
            m_startClientButton.onClick.AddListener(() => HandleOnClickStartClientButton());
        }
        private void HandleOnClickStartHostButton(){
            NetworkManager.Singleton.StartHost();
            DisableButtons();
        }
        private void HandleOnClickStartClientButton(){
            NetworkManager.Singleton.StartClient();
            DisableButtons();
        }
        private void DisableButtons(){
            m_startHostButton.interactable = false;
            m_startClientButton.interactable = false;
        }
    }
}