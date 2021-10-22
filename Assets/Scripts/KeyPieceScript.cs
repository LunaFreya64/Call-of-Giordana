using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPieceScript : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        playerControllerScript.keyPieces = playerControllerScript.keyPieces + 1;
        Destroy(gameObject);
    }
}
