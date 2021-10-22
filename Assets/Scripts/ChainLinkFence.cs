using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainLinkFence : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerController playerControllerScript;
    private Collider fenceCollider;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        fenceCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.form == 1)
        {
            fenceCollider.isTrigger = true;
        } else{
            fenceCollider.isTrigger = false;
        }
    }
}
