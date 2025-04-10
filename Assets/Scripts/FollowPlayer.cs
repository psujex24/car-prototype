using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0.02f, 7.28f, -11.03f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // funkcja odpowiadajaca za sledzenie pojazdu tylko po jednej osii (możliwy rozwoj w przyszłosci)
        transform.position = player.transform.position + offset;
    }
}
