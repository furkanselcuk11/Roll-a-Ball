using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public GameObject ball; // Hedef obje
    //Vector3 distanceBetween;    // Hedef obje ile kamera aras�ndaki uzakl�k fark�

    [SerializeField] Transform target;    // Takip edilecek nesne
    [SerializeField] Vector3 offset;  // Ne kadar uzakl�ktan  takip edecek 

    [SerializeField] float lerpValue;
    void Start()
    {
        // Karakter ile kamera aras�ndaki fark� bulmak i�in kameran�n pozisyonundan karakterin pozsiyonu ��kar�l�r
        //distanceBetween = transform.position - ball.transform.position; // Hedef obje ile kamera aras�ndaki uzakl�k fark� hesaplan�r

    }
    void LateUpdate()
    {
        // LateUpdate - T�m Updateler �al��t�ktan sonra �al���r
        // Kameralar i�in genelde LateUpdate kullan�l�r, daha yava� �al���r ve yumu�ak ge�i� sa�lar
        // Kameran�n oyun s�ras�ndaki konumu
        //transform.position = ball.transform.position + distanceBetween;

        Vector3 desPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desPos, lerpValue);
    }
}
