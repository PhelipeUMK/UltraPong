using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidade = 100;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1; // Isto � um tipo deiferente de condi��o " if "
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector2(velocidade * x,velocidade * y);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
