using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGoalScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI gameOverText2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameOverText2.gameObject.SetActive(true);
        gameOverText2.text = "You Win!";
    }
}
