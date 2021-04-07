using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    private float offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.z - player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, offset);
    }
}
