using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalInput;
    private float forwardInput;
    public float speed = 20.0f;
    public float health = 20.0f;
    public float anxiety = 0.0f;
    public SpriteRenderer spriteRenderer;
    public Sprite baseForm;
    public Sprite shoggoth;
    public Sprite cthulhu;
    public bool inForm = false;
    public bool haveStome = false;
    public bool haveCtome = false;
    public float keyPieces = 0;
    public float form = 0;
    
    void Start()
    {
        StartCoroutine(IncreaseAnxiety());
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*Time.deltaTime*speed*forwardInput);
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);

        if (Input.GetKeyDown(KeyCode.Alpha1) && haveStome)
        {
            inForm = true;
            form = 1;
            spriteRenderer.sprite = shoggoth;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inForm = false;
            form = 0;
            spriteRenderer.sprite = baseForm;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && haveCtome)
        {
            inForm = true;
            spriteRenderer.sprite = cthulhu;
        }
    }
        IEnumerator IncreaseAnxiety()
        {
            yield return new WaitForSeconds(1);
            if (inForm == true && anxiety < 100)
            {
                anxiety = anxiety + 1;
            } else if (inForm == false && anxiety > 0){
                anxiety = anxiety - 1;
            }

            if (anxiety == 100)
            {
                health = health - 1;
            }
            StartCoroutine(IncreaseAnxiety());
        }
}
