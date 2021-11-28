using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Networking;

public class moving : MonoBehaviour
{

    private CharacterController characterController;
    public Transform transformMainCamera;
    public Transform transformSimplePlayer;
    private float speed = 6f;
    public Camera cam;
    // Start is called before the first frame update

    void Start()
    {

        characterController = GetComponent<CharacterController>();

        // IF I'M THE PLAYER, STOP HERE (DON'T TURN MY OWN CAMERA OFF)
        //if (isLocalPlayer) return;

        // DISABLE CAMERA AND CONTROLS HERE (BECAUSE THEY ARE NOT ME)
        cam.enabled = true;
        //GetComponent<PlayerControls>().enabled = false;
        //GetComponent<PlayerMovement>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (!isLocalPlayer)
            //return;

        Vector3 forward = transformMainCamera.TransformDirection(Vector3.forward);
        Vector3 right = transformMainCamera.TransformDirection(Vector3.right);




        characterController.SimpleMove(right * speed * Input.GetAxis("Horizontal"));
        characterController.SimpleMove(forward * speed * Input.GetAxis("Vertical"));


    }
}
