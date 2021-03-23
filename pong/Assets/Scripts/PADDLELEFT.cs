using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PADDLELEFT : MonoBehaviour
{
    [SerializeField]
    float velocidade = 0.5f;

    [SerializeField]
    float paddlemov = 1f;

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            transform.position += velocidade * Vector3.up * Time.deltaTime;

        }
        else if (Input.GetKey(downKey))
        {
            transform.position += velocidade * Vector3.down * Time.deltaTime;
        }
        float CAMARAHEIGHT = Camera.main.orthographicSize;
        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(positionAux.y, -CAMARAHEIGHT + (paddlemov / 2), CAMARAHEIGHT - (paddlemov / 2));
        transform.position = positionAux;
    }
}
