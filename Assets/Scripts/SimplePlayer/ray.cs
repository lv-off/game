using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{

    public GameObject prefGun;
    private GameObject gun;
    public Transform muzzle;


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
        if (col.tag == "Player")
        Instantiate(prefGun, muzzle.position, muzzle.rotation,muzzle.parent);
    }
}
