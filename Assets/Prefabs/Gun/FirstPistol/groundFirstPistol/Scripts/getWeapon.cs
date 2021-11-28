using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class getWeapon : MonoBehaviour
{
    public GameObject gun;
    public GameObject prefGun;
    public Transform muzzle;
    public GameObject playerPocket;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (GameObject.Find("handsFirstPistol") == null)
        {
            if (col.tag == "Player")
            {
                Destroy(gun, 0f);
                Instantiate(prefGun, muzzle.parent);
            }
        }
        


    }
}
