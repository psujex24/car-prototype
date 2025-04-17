using UnityEngine;

public class PlayerControlP2 : MonoBehaviour
{
    // Prywatne zmienne
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = 0f;
        float turnInput = 0f;

        // Ruch do przodu i do tyłu
        if (Input.GetKey(KeyCode.W))
        {
            moveInput = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveInput = -1f;
        }

        // Skręcanie wraz z walidacja żeby nie poruszac sie wokol wlasneij osi bez "napędu"
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            turnInput = -1f;
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            turnInput = 1f;
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            turnInput = 1f;
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            turnInput = -1f;
        }

        // Przesuwanie pojazdu
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput);

        // Obracanie pojazdu
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * turnInput);
    }
}
