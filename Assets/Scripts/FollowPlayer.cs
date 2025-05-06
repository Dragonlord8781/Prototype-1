using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //gets player gameobject
    public GameObject player;
    //creates offset
    private Vector3 offset = new Vector3(0, 5, -8);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once every other frame. maybe?
    void LateUpdate()
    {
        //sets position to player's + offeset
        transform.position = player.transform.position + offset;
    }
}
