using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
using System.Collections.Generic;

public class Riddle : MonoBehaviour{
    [SerializeField] private int riddlesPerSet = 4;
    [SerializeField] public int index;
    [SerializeField] public int roomNumber;
    [SerializeField] public TMP_Text riddleText;
    public Texture[] riddleIndex = new Texture[4];
    public Texture buttonTexture;

    private GameObject[] riddles = new GameObject[4];
    private GameObject riddle;
    public Dictionary<int, string[]> roomRiddles;
    
    [SerializeField] private Canvas RiddlePopUp;

    public static Riddle instance;

    void Start(){
        //riddleIndex = new Texture[4];
        if (!instance) instance = this;
        RiddlePopUp.enabled = false;
        riddles = new GameObject[4];    // Hardcoded value. Remove later
        // get all the children of the parent
        //int j = 0;
        for (int i = 0; i < riddlesPerSet; i++){
            if (transform.GetChild(i).CompareTag("Riddle")){
                riddles[i] = transform.GetChild(i).gameObject;
                riddles[i].GetComponent<Renderer>().material.SetTexture("_MainTex", riddleIndex[i]);
                riddles[i].GetComponent<Renderer>().material.SetTextureScale("_MainTex", new Vector2(-1,-1));
                //j++;
            }
        }
        transform.GetChild(4).GetComponent<Renderer>().material.SetTexture("_MainTex", buttonTexture);
        transform.GetChild(4).GetComponent<Renderer>().material.SetTextureScale("_MainTex", new Vector2(-1, -1));
    }

    void Update(){
        if (riddle && riddle.GetComponent<Renderer>().material.color == Color.green){
            if (riddle.GetComponent<XRSimpleInteractable>().isSelected){
                ShowRiddle();
            }
        } 
        if (RiddlePopUp.enabled){
            if (Input.GetKeyDown(KeyCode.Escape)){
                HideRiddle();
            }
        }
    }
    public void SetIndex(){
        riddle = riddles[index];
        riddle.GetComponent<Renderer>().material.color = Color.green;
        riddle.gameObject.AddComponent<XRSimpleInteractable>();
        SetRiddle();
    }

    public void SetRiddle(){
        // add riddle to the next room number
        int index = Random.Range(0,3);
        if (roomNumber > 0) riddleText.SetText(Hints.instance.riddlesForEachRoom[roomNumber][index]);
        else riddleText.SetText("Oops!. You seem lost. Go back to where you started.");
    }

    public void ShowRiddle(){
        Debug.Log(roomNumber);
        RiddlePopUp.enabled = true;
    }

    public void HideRiddle(){
        RiddlePopUp.enabled = false;
    }
}
