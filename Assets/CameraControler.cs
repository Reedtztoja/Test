using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerVector;
    // Start is called before the first frame update
    void Start()
    {
        playerVector = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //sledzenie poprzez obrot
        //useless: Vector3 playerPosition = GameObject.Find("Cube").transform.position;
        //Vector3 playerPosition = player.transform.position;
        //transform.LookAt(playerPosition);

        //przesuniecie do pozycji gracza + wektor przesuniecia
        transform.position = player.transform.position + playerVector;
    }
}
