using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ball;
    Vector3 distanceBetween;
    void Start()
    {
        // Karakter ile kamera aras�ndaki fark� bulmak i�in kameran�n pozisyounndan karakterin pozsiyonu ��kar�l�r
        distanceBetween = transform.position - ball.transform.position;
        
    }
    void LateUpdate()
    {
        // LateUpdate - T�m Updateler �al��t�ktan sonra �al���r
        // Kameralar i�in genelde LateUpdate kullan�l�r, daha yava� �al���r ve yumu�ak ge�i� sa�lar
        // Kameran�n oyun s�ras�ndaki konumu
        transform.position = ball.transform.position + distanceBetween;
    }
}
