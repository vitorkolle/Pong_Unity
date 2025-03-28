using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidade = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().linearVelocity = new Vector2(velocidade * x, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
