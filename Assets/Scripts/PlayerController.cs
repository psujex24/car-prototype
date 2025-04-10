using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    // Prywatne zmienne
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Wyłapywanie użycia klawiszow ruchu przez gracza
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        // pojazd porusza sie prosto 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // skręcanie pojazdu (mozna dodac walidacje podczas braku poruszania sie)
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
