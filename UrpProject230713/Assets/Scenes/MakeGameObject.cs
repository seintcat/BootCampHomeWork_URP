using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGameObject : MonoBehaviour
{
    public Mesh mesh;

    private void Awake()
    {
        GameObject player = new GameObject();
        player.name = "Player";
        player.transform.position = new Vector3 (1, 1, 0);
        player.AddComponent<MeshFilter>();
        player.GetComponent<MeshFilter>().mesh = mesh;
        player.AddComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
