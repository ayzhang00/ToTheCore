using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class TEMPListUsers : MonoBehaviourPun
{
    public GameObject usernames;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        usernames.GetComponent<TMP_Text>().text = PhotonNetwork.CurrentRoom.PlayerCount.ToString();
    }
}
