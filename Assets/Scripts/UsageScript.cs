using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsageScript : MonoBehaviour
{
    private UDPReceive connection;

    void Start()
    {
        string sendIp = "127.0.0.1";
        int sendPort = 8881;
        int receivePort = 11000;

        connection = new UDPReceive();
        connection.StartConnection(sendIp, sendPort, receivePort);
    }

    void Update()
    {
        foreach (var message in connection.getMessages()) Debug.Log(message);

        connection.Send("Hi!");
    }

    void OnDestroy()
    {
        connection.Stop();
    }
}
