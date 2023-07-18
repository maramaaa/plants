using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public Transform Player;
    private Transform tr;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector2.Distance(tr.transform.position, Player.position)< 2.0f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("TestText");
        }
            
    }
}
// Assets/Scenes/Test Text.unity



