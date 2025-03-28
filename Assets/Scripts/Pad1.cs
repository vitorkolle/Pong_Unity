using UnityEngine;

public class Pad1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical2") > 0 && transform.position.y < 5f)
        {
            transform.Translate(0, 0.1f, 0);
        }
        else if (Input.GetAxisRaw("Vertical2") < 0 && transform.position.y > -2.82f)
        {
            transform.Translate(0, -0.1f, 0);
        }
    }
}
