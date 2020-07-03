using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Control_Ball : MonoBehaviour
{
    Rigidbody physic;
    public int speed;
    int counter = 0;
    public int countingObjectNumber;
    public Text counterText;
    public Text TheEndText;

    void Start()
    {
        physic = GetComponent<Rigidbody>();



 }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(horizontal, 0, vertical);
        physic.AddForce(vec*speed);

       // Debug.Log("horizontal =" + horizontal+ "vertical =" + vertical );
    
    }
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Blocker")
        {
            other.gameObject.SetActive(false);
            counter++;
            counterText.text = "Counter =  " + counter;

            if (counter== countingObjectNumber)
            {
                TheEndText.text = "THE END!";
            }
            
        }

    }
}
