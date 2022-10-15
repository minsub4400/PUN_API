using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// Place-bet
public struct placeBet
{
    public string[] players_session_id;
    public string bet_id;
}

public class MatchDetails
{
}

// Winner
public struct winner
{
    public string betting_id;
    public string winner_player_id;
    public MatchDetails match_details; // �� ��
}

// Disconnect
public struct disconnect
{
    public string betting_id;
}

public class APIStorage : MonoBehaviour
{
    // ###############################################
    //             NAME : Simstealer                      
    //             MAIL : minsub4400@gmail.com         
    // ###############################################

    // ������ ������ 2�δ����� �Ѵ�.
    // [0] : Player1(Host), [1] : Player2(Client)

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public int[] playerNumber = new int[2];

    public string apiKey = "507zw8P8wfd3KUttpJRfd0";

    // ���� ���� �غ� ����
    public bool[] ready = new bool[2];

    // ������ ��ȭ�� ������ ����
    public string[] zera = new string[2];
    public string[] ace = new string[2];
    // API ȣ�� ���� �ڵ� 200�� �ƴϸ� ������ ��ȯ�Ѵ�.
    public string[] statusCode = new string[2];

    // ���� ���� ID
    public string[] _id = new string[2];

    // ���� ���� �̸�
    public string[] userName = new string[2];

    // �Ź� �ٲ�� ���� ID
    public string[] session_id = new string[2];

    // Post �޼��� ȣ�� ��, "success"
    public string[] message = new string[2];

    // �¸��� ����
    public string amount_won;

    // ���ÿ� �ʿ��� ID
    public string[] bet_id = new string[2];

    // ������ �ߴٴ� ���� ������ ���� �ִ� ID
    public string betting_id;

    // ����� id
    public string winner_id = "633b05680e028f7ecb10fd01";

    // (�ӽ�) MetaMask _id(�׽�Ʈ �뵵)
    public string MetaMaskSessionID = "mn9EqUQZJORX4TRBWkBdn9GKu1bsiTxbimK4ywVI";

}