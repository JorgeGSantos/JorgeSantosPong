using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOLAMOV : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    float tempo = 0f;
    float esperar = 2f;
    bool lancamento = false;

    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;
        if (lancamento == false)
        {
            if(tempo > esperar)
            {
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.onUnitSphere;
                lancamento = true;
            }
        }
    }
}
