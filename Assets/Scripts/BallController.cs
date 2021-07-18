using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    Rigidbody physics;
    public float speed;

    int counter=0;
    public int totalColletObject;

    public Text counterText;
    public Text gameOverText;

    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }
     void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(horizontal, 0, vertical);
        physics.AddForce(vec * speed);
        Debug.Log("hýz:"+speed);

    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collected")    // Çarpýlan objenin tagý ayný ise iþlem yap
        {
            Destroy(other.gameObject);  // Çarpýlan objeyi yok et
            counter++;
            counterText.text = "Skor: " + counter;
            

            if (counter == totalColletObject)
            {
                gameOverText.text = "Oyun Bitti!!!";
                Time.timeScale = 0.0f;
            }
        }
    }

}
