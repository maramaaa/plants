using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class Textdisplay : MonoBehaviour
{
    public Dialog dialog;
    public TMP_Text charanterName;
    public TMP_Text words;
    
    private int num = 0;
    // Update is called once per frame

    private void Start()
    {

                
        string pathRsc = "Assets/Dialog/TestDialog.asset";
        //AssetDatabase.ImportAsset(pathRsc, ImportAssetOptions.ImportRecursive);
        var dialPath = AssetDatabase.LoadMainAssetAtPath(pathRsc);
        AssetDatabase.OpenAsset(dialPath);
        AssetDatabase.Refresh();
        //dialog = GetComponent<Dialog>();
        

    }
    
    void Update()
    { 
        charanterName.text = dialog.prases[num].speaker;
        words.text = dialog.prases[num].words;
        if (Input.GetKeyDown("space")) num++;
        if (num >= dialog.prases.Length) UnityEngine.SceneManagement.SceneManager.LoadScene("Map");
    }
}