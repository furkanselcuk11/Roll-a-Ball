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
        allObject = FindObjectsOfType<CollectedObject>();   // Sanhe �zerindeki toplanacak obje say�s�
        totalColletObject = allObject.Length;   // Sanhe �zerindeki toplanacak obje say�s�n� "totalColletObject" de�i�kenine aktar�r
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
        if (other.gameObject.tag == "collected")    // �arp�lan objenin tag� "collected" ise i�lem yap
        {
            Destroy(other.gameObject);  // �arp�lan objeyi yok et
            counter++;  // Counter bir artt�r
            counterText.text = "Skor: " + counter;
            

            if (counter == totalColletObject)   // Toplanan obje say�s� toplam obje say�s�na e�itse oyun biter
            {
                gameOverText.text = "Oyun Bitti!!!";
                Time.timeScale = 0.0f;
            }
        }
    }

}
