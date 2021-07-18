using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ball;
    Vector3 distanceBetween;
    void Start()
    {
        // Karakter ile kamera arasýndaki farký bulmak için kameranýn pozisyounndan karakterin pozsiyonu çýkarýlýr
        distanceBetween = transform.position - ball.transform.position;
        
    }
    void LateUpdate()
    {
        // LateUpdate - Tüm Updateler çalýþtýktan sonra çalýþýr
        // Kameralar için genelde LateUpdate kullanýlýr, daha yavaþ çalýþýr ve yumuþak geçiþ saðlar
        // Kameranýn oyun sýrasýndaki konumu
        transform.position = ball.transform.position + distanceBetween;
    }
}
