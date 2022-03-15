using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0.5f, 0.5f, 0);
    //private Vector3 rotationOffset = new Vector3(28f, 0, 0);


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

       /* float playerRotation = player.transform.rotation;
              
        Quaternion rotation = Quaternion.Euler(28f, (player.transform.rotation), 0);
        transform.rotation = rotation * Quaternion.Euler(0, -90, 0); */

        //public Vector3 mAngleOffset = new Vector3(0.0f, 0.0f, 0.0f);


}
}
