using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectilePrefab;
    void Start()
    {
        StartCoroutine(SpawnFireball());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnFireball()
    {
        yield return new WaitForSeconds(2);
        Instantiate(projectilePrefab, transform.position + new Vector3(1,0,1), transform.rotation);
        Instantiate(projectilePrefab, transform.position + new Vector3(-1,0,-1), transform.rotation);
        StartCoroutine(SpawnFireball());
    }
}
