using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private int counter;
    public Text currentText;
    public Text winText;
    private Rigidbody rb;
    public PickupGenerator pickupGenerator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        counter = 0;
        this.updateText();
        winText.text = "";
    }

    void updateText()
    {
        currentText.text = "Count: " + counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement =  new Vector3(h, 0, v);

        rb.AddForce(movement * speed);
    }

    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.gameObject.CompareTag("Pickup"))
        {
            otherObject.gameObject.SetActive(false);
            this.pickupGenerator.createNewGObj();
            counter++;
            if (counter == 5) winText.text = "DUNZO?";
            this.updateText();
        }
    }
}
