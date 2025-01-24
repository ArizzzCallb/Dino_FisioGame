using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public Rigidbody2D rb;
    public float forcaPulo;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pular();

        }
        void Pular()
        {
            rb.AddForce(Vector2.up * forcaPulo);

        }

    }
}
