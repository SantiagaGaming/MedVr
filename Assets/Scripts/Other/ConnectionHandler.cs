using Mirror;
using TMPro;
using UnityEngine;

public class ConnectionHandler : MonoBehaviour
{

    public delegate void ReadyToPlay();
    public event ReadyToPlay ReadyToPlayEvent;

    [SerializeField] private NetworkButton _hostButton;
    [SerializeField] private NetworkButton clientButton;
    [SerializeField] private NetworkManager _manager;

    [SerializeField] private TextMeshProUGUI _ipText;

    private void Start()
    {
        _hostButton.ButtonClickedEvent += OnHandleNetworkButtonClick;
        clientButton.ButtonClickedEvent += OnHandleNetworkButtonClick;
    }
    private void OnHandleNetworkButtonClick(NetworkButtonState state)
    {
        if (state == NetworkButtonState.Client)
        {
            _manager.StartClient();
            _manager.networkAddress= _ipText.text;
        }
        else if(state == NetworkButtonState.Host)
            _manager.StartHost();
        ClientReady();
    }
    private void ClientReady()
    {
        NetworkClient.Ready();
        if (NetworkClient.localPlayer == null)
        {
            NetworkClient.AddPlayer();
        }
        ReadyToPlayEvent?.Invoke();
    }
}
