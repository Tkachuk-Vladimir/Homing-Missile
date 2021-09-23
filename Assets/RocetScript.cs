using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class RocetScript : MonoBehaviour
{
    public Transform target;
    public float rocetSpeed = 5f;
    public float rocetRotateSpeed = 200f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = transform.up * rocetSpeed;

        Vector2 direction = (Vector2)target.position - rb.position; // находим вектор до цели

        direction.Normalize();// вычисляем нормаль к вектору direction

        float rotateAmount = Vector3.Cross(direction, transform.up).z; // Вычисляем угол между ракетой и лет.тарелкой

        rb.angularVelocity = -rotateAmount * rocetRotateSpeed; // з
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }

}
