using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // ###############################################
    //             NAME : Simstealer                      
    //             MAIL : minsub4400@gmail.com         
    // ###############################################

    void Start()
    {
        // ������ ����
        PhotonNetwork.ConnectUsingSettings();
    }

    // ������ ������ �����ϸ�
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 2}, null);
    }

    public override void OnJoinedRoom()
    {
        // �濡 ���� ������
        Vector3 vector3 = new Vector3(0f, 1f, 0f);
        PhotonNetwork.Instantiate("Player", vector3, Quaternion.identity);
    }


}
