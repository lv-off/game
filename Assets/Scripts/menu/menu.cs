using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Networking;

public class menu : MonoBehaviour
{
    public GameObject plane1;
    public GameObject plane2;
    public int choose;
    /*public NetworkManager manager;
    public NetworkDiscovery discovery;
    public NetworkBroadcastResult stat;*/

    // Start is called before the first frame update
    void Start()
    {
        plane1.GetComponent<MeshRenderer>().material.color = Color.red;
        choose = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") < 0)
            {
                plane2.GetComponent<MeshRenderer>().material.color = Color.red;
                plane1.GetComponent<MeshRenderer>().material.color = Color.white;
            choose = 2;
                

            }
        if (Input.GetAxis("Vertical") > 0)
            {
                plane1.GetComponent<MeshRenderer>().material.color = Color.red;
                plane2.GetComponent<MeshRenderer>().material.color = Color.white;
            choose = 1;

        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (choose == 1)
            {
                /*manager.StartClient();
                ClientScene.Ready(manager.client.connection);
                ClientScene.AddPlayer(0);
                discovery.StartAsClient();
                stat = discovery.broadcastsReceived;
                manager.StartClient();

                if (discovery.Initialize())
                {
                discovery.StartAsClient();
                print(" Back to listening , hostId : " + discovery.hostId);
                }*/
                SceneManager.LoadScene("FirstScene", LoadSceneMode.Single);

            }
            if (choose == 2)
            {
                /*manager.StartHost();
                if (discovery.Initialize())
                {
                    //discovery.StartAsServer();
                    //print("Starting as an Host on hostId : " + discovery.hostId);
                }*/
            }
        }




    }
}
