using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0 && transform.position.y < 6.2f){
            transform.Translate(0, 0.1f, 0);
        }
        //
        else if (Input.GetAxisRaw("Vertical") < 0 && transform.position.y > -1.10f){
            transform.Translate(0, -0.1f, 0);
        } 
        //
        if (Input.GetAxisRaw("Horizontal") > 0 && transform.position.x < 10.8f){
            transform.Translate(0.1f, 0, 0);
        } 
        else if (Input.GetAxisRaw("Horizontal") < 0 && transform.position.x > -10.3f){
            transform.Translate(-0.1f, 0, 0);
        } 
        //
        if (Input.GetAxisRaw("Fire2") > 0){
            transform.Translate(0, 0, 0.1f);
        } 
        else if (Input.GetAxisRaw("Fire3") > 0)
        {
            transform.Translate(0, 0, -0.1f);
        }
    }
}
