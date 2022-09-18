using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public static MenuManager Instance;
    public InputField nameInput;
    public string playerName;

    private void Awake() {
                // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update() {
        if(nameInput.text != "")
            playerName = nameInput.text;
    }

    public void LoadMain(){
        SceneManager.LoadScene(1);
    }

}
