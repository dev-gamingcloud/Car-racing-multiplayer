using System.Collections;
using System.Collections.Generic;
using gamingCloud.Network;
using UnityEngine;

public class serverManager : GCMultiPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        ConnectToMultiPlayerServer();
    }

    public override void ConnectedToServer()
    {
        JoinToServer(new RoomSetting());
    }
    public override void OnJoined()
    {
        GameObject spnPoint = GameObject.Find("spn-" + spawnIndex);
        GameObject.FindGameObjectWithTag("Player").transform.position = spnPoint.transform.position;
    }
    void Update()
    {

    }
}
