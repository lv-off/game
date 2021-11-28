using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handsFirstPistol : MonoBehaviour
{
    private AudioSource shotSound;
    public Transform muzzle;
    public GameObject bulletPref;
    private GameObject bullet;
    private float power=500f;
    // Start is called before the first frame update
    void Start()
    {
        shotSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shotSound.Play();
            Shot();    
        }
    }

    void Shot()
    {
        bullet = Instantiate(bulletPref, muzzle.position, muzzle.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * power, ForceMode.Impulse);
        Destroy(bullet, 1f);
    }
}
