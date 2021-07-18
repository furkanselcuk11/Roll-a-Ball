using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    int counter=0;
    public int totalColletObject;

    public Text counterText;
    public Text gameOverText;

    private CollectedObject[] allObject;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        allObject = FindObjectsOfType<CollectedObject>();   // Sanhe üzerindeki toplanacak obje sayýsý
        totalColletObject = allObject.Length;   // Sanhe üzerindeki toplanacak obje sayýsýný "totalColletObject" deðiþkenine aktarýr
    }
     void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(horizontal, 0, vertical);
        rb.AddForce(vec * speed);
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collected")    // Çarpýlan objenin tagý "collected" ise iþlem yap
        {
            Destroy(other.gameObject);  // Çarpýlan objeyi yok et
            counter++;  // Counter bir arttýr
            counterText.text = "Skor: " + counter;
            

            if (counter == totalColletObject)   // Toplanan obje sayýsý toplam obje sayýsýna eþitse oyun biter
            {
                gameOverText.text = "Oyun Bitti!!!";
                Time.timeScale = 0.0f;
            }
        }
    }

}
