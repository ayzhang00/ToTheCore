using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadServer : MonoBehaviourPunCallbacks
{
    // username
    public GameObject usernameInput;
    public GameObject connect;

    // check if user has input username
    private void Update() {
        if (usernameInput.GetComponent<TMP_InputField>().text.Length >= 1) {
            connect.SetActive(true);
        }
    }

    // connect is clicked
    public void OnClickConnect() {
        PhotonNetwork.NickName = usernameInput.GetComponent<TMP_InputField>().text;
        PhotonNetwork.ConnectUsingSettings();
    }

    // joins a lobby which can contain a bunch of rooms
    public override void OnConnectedToMaster() {
        PhotonNetwork.JoinLobby();
    }

    // as titled: when joined lobby, load the scene "Lobby"
    public override void OnJoinedLobby() { 
        SceneManager.LoadScene("Lobby");
    }
}
