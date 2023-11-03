using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public Canvas mainMenu;
    public TMPro.TMP_InputField inputField;
    public static int level;
    void Start()
    {
        mainMenu.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (inputField.text.Length > 0)
        {
            char ch = inputField.text[0];
            if (ch - '0' >= 0 && ch - '0' <= 9)
            {
                level = ch - '0';
            }
        }
    }

    public void switchScene()
    {
        SceneManager.LoadScene(1);
    }
}
