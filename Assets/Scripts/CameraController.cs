using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public GameObject ball; // Hedef obje
    //Vector3 distanceBetween;    // Hedef obje ile kamera arasýndaki uzaklýk farký

    [SerializeField] Transform target;    // Takip edilecek nesne
    [SerializeField] Vector3 offset;  // Ne kadar uzaklýktan  takip edecek 

    [SerializeField] float lerpValue;
    void Start()
    {
        // Karakter ile kamera arasýndaki farký bulmak için kameranýn pozisyonundan karakterin pozsiyonu çýkarýlýr
        //distanceBetween = transform.position - ball.transform.position; // Hedef obje ile kamera arasýndaki uzaklýk farký hesaplanýr

    }
    void LateUpdate()
    {
        // LateUpdate - Tüm Updateler çalýþtýktan sonra çalýþýr
        // Kameralar için genelde LateUpdate kullanýlýr, daha yavaþ çalýþýr ve yumuþak geçiþ saðlar
        // Kameranýn oyun sýrasýndaki konumu
        //transform.position = ball.transform.position + distanceBetween;

        Vector3 desPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desPos, lerpValue);
    }
}
