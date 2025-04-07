using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    public float velocidade = 10;
    int pontosJog1 = 0;
    int pontosJog2 = 0;
    public TMP_Text TextoPontosJog2;
    public TMP_Text TextoPontosJog1;
    public GameObject power;
    public Camera camPrincipal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Jogador 1: " + pontosJog1 + " X Jogador 2: " + pontosJog2);

        TextoPontosJog2.SetText(pontosJog2.ToString());
        TextoPontosJog1.SetText(pontosJog1.ToString());

        if (pontosJog2 >= 3 || pontosJog1 >= 3)
        {
            SceneManager.LoadScene("GameOver");
        }

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().linearVelocity = new Vector2(velocidade * x, y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision batida)
    {
        if (batida.gameObject.name == "Barreira_direita"){
            transform.position = new Vector3(0, 1.86f, 0.15f);
            pontosJog2++;
            Start();
        }
        
        else if (batida.gameObject.name == "Barreira_esquerda"){
            transform.position = new Vector3(0, 1.86f, 0.15f);
            pontosJog1++;
            Start();
        }
        else if (batida.gameObject.tag == "PowerUp"){
            power.SetActive(false);
            camPrincipal.transform.Rotate(0,0,180);
            StartCoroutine(Fim());
        }

        GetComponent<AudioSource>().Play();
    }

    //Não precisa invocar um GameObject, já que ele ativa pelo trigger, que já é ativo no elemento
    private void OnTriggerEnter(Collider toque){
        if (toque.gameObject.name == "Power2"){
            camPrincipal.fieldOfView = 100;
            toque.gameObject.SetActive(false);

            StartCoroutine(ReturnFieldOfView());
        }
    }

    IEnumerator ReturnFieldOfView(){
        yield return new WaitForSeconds(5);
        camPrincipal.fieldOfView = 60;
    }


    IEnumerator Fim(){
        yield return new WaitForSeconds(1);
        camPrincipal.transform.Rotate(0,0,180);
    }
}
