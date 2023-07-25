using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public Transform Player;
    private Transform tr;
    private Renderer rend;
    public GameObject dialogWindow;

    private bool isInit;

    // Start is called before the first frame update
    void Start()
    {
        dialogWindow.SetActive(false);
        tr = GetComponent<Transform>();
        //rend = GetComponent<Renderer>();
        
        isInit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector2.Distance(tr.transform.position, Player.position)< 2.0f)
        {
            
            dialogWindow.SetActive(true);
            isInit = true;

            //UnityEngine.SceneManagement.SceneManager.LoadScene("TestText");
        }

        else if (isInit)
        {
            dialogWindow.SetActive(false);
            isInit = false;
        }
            
    }
}
// Assets/Scenes/Test Text.unity dialog   dialog



