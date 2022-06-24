using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public GameObject CreateInput;
    public GameObject JoinInput;
    public GameObject CreatePanel;
    public GameObject JoinPanel;

    public void OnClickCreatePanel() {
        CreatePanel.SetActive(true);
        JoinPanel.SetActive(false);
    }

    public void OnClickJoinPanel() {
        JoinPanel.SetActive(true);
        CreatePanel.SetActive(false);
    }

    public void OnClickCreate() {
        var t = CreateInput.GetComponent<TMP_InputField>().text;
        if (t.Length >= 1) {
            PhotonNetwork.CreateRoom(t);
        }
    }

    public void OnClickJoin() {
        var t = JoinInput.GetComponent<TMP_InputField>().text;
        if (t.Length >= 1) {
            PhotonNetwork.JoinRoom(t);
        }
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.LoadLevel("Room");
    }
}
