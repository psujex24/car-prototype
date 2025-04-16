using UnityEngine;

public class SwitchingCamera : MonoBehaviour
{
    private Vector3 firstPersonView = new Vector3(0.04f, 4.56f, -0.26f);
    private Vector3 thridPersonView = new Vector3(0.02f, 7.28f, -11.03f);
    bool isFirstPerson = false;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            isFirstPerson = !isFirstPerson;

        }
        if (isFirstPerson)
        {

            transform.position = player.transform.position + firstPersonView;
            transform.rotation = player.transform.rotation;


        }
        else //problemy z kamera w 3 osobie w pierwszej tez ale to mniej widoczne 
        {
            transform.position = player.transform.position + thridPersonView;
            transform.rotation = player.transform.rotation;
        }

    }
}
