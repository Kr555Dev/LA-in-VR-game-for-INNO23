using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using TMPro;
using System.Data.SqlTypes;
using UnityEngine.InputSystem.Layouts;

public class RiddleManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int level;
    [SerializeField] private GameObject[] riddle;
    [SerializeField] private TMPro.TMP_InputField inputField;
    public int[,] sets;
    private int [][] winningCombinations;

    Dictionary<int, int[]> room;
    Dictionary<int, int[]> locations;
    Dictionary<int, string[]> roomRiddles;
    Dictionary<int, GameObject> roomRiddleSetMappings;
    private int[] visited = new int[6];

    void Start(){
        // Initialization
        sets = new int[6,4]{ 
            {3,2,1,4},
            {4,3,2,6},
            {1,5,4,2},
            {6,1,3,5},
            {1,6,5,3},
            {4,2,5,6}
        };
        // 1 2 2 3
        winningCombinations = new int[12][];
        winningCombinations[0] = new int[5]{0,14,9,13,12};
        winningCombinations[1] = new int[5]{0,9,22,10,20};
        winningCombinations[2] = new int[5]{0,22,13,16,23};
        winningCombinations[3] = new int[5]{0,21,13,16,17};
        winningCombinations[4] = new int[5]{0,7,5,11,12};
        winningCombinations[5] = new int[5]{0,2,20,10,18};
        winningCombinations[6] = new int[5]{0,1,24,5,12};
        winningCombinations[7] = new int[5]{0,9,11,17,6};
        winningCombinations[8] = new int[5]{0,7,23,10,5};
        winningCombinations[9] = new int[5]{0,14,13,12,16};
        // winningCombinations[10] = new int[4]{8,13,6,12};
        // winningCombinations[11] = new int[4]{8,13,6,12};
        
        //TODO: Update indices
        room = new Dictionary<int, int[]>();
        room.Add(1, new int[5]{0,3,4,8,19});  //0
        room.Add(2, new int[5]{0,14,2,22,7}); //1 GH1
        room.Add(3, new int[5]{0,21,9,1,15}); //1 GH2
        room.Add(4, new int[5]{0,5,6,13,20}); //2 F1H1
        room.Add(5, new int[5]{0,10,24,16,11}); //2 F1H2
        room.Add(6, new int[5]{0,12,18,17,23}); //2 F1H3

        locations = new Dictionary<int, int[]>();
        locations.Add(1, new int[2]{3,2});
        locations.Add(2, new int[2]{2,1});
        locations.Add(3, new int[2]{1,0});
        locations.Add(4, new int[2]{1,1});
        locations.Add(5, new int[2]{4,0});
        locations.Add(6, new int[2]{4,1});
        locations.Add(7, new int[2]{2,3});
        locations.Add(8, new int[2]{1,2});

        locations.Add(9, new int[2]{3,1});
        locations.Add(10, new int[2]{5,0});
        locations.Add(11, new int[2]{5,3});
        locations.Add(12, new int[2]{6,0});
        locations.Add(13, new int[2]{4,2});
        locations.Add(14, new int[2]{2,0});
        locations.Add(15, new int[2]{3,3});
        locations.Add(16, new int[2]{5,2});

        locations.Add(17, new int[2]{6,2});
        locations.Add(18, new int[2]{6,1});
        locations.Add(19, new int[2]{1,3});
        locations.Add(20, new int[2]{4,3});
        locations.Add(21, new int[2]{3,0});
        locations.Add(22, new int[2]{2,2});
        locations.Add(23, new int[2]{6,3});
        locations.Add(24, new int[2]{5,1});

        roomRiddles = new Dictionary<int, string[]>();
        level = MainMenu.level;
        //Game starts here
        SetRiddles();
    }

    private void Update()
    {
        if (inputField.text.Length > 0)
        {
            char c = inputField.text[0];
            if (c - '0' >= 0 && c - '0' <= 9)
            {
                level = c - '0';
            }
        }
    }

    private void SetRiddles(){
        // set the riddles according to the value of sets[i].
        // set riddles on level 1
        int[] winningCombination = new int [5];
        winningCombination = winningCombinations[level];
        int[] idx = new int[4];
        int[] nextRoomNumber = new int[4];
        // get the index of the riddle and the next room number based on winning combination
        for (int i = 0; i < 4; i++){
            idx[i] = locations[winningCombination[i+1]][1];
            nextRoomNumber[i] = locations[winningCombination[i+1]][0];
        }
        // for (int i = 0; i < 4; i++){
        //     riddle[i].GetComponent<Riddle>().index = idx[i]; //highlight index
        //     riddle[i].GetComponent<Riddle>().roomNumber = nextRoomNumber[i];    // next room's riddle
        // }

        for (int i = 0; i < 4; i++){
            if (i == 0){
                visited[i] = 1;
                riddle[i].GetComponent<Riddle>().index = idx[i];
                riddle[i].GetComponent<Riddle>().roomNumber = nextRoomNumber[i];
            }
            else{
                visited[nextRoomNumber[i-1]-1] = 1;
                riddle[nextRoomNumber[i-1]-1].GetComponent<Riddle>().index = idx[i];
                riddle[nextRoomNumber[i-1]-1].GetComponent<Riddle>().roomNumber = nextRoomNumber[i];
            }
        }

        for (int i = 0; i < 6; i++){
            if (visited[i]==0){
                riddle[i].GetComponent<Riddle>().index = 0;
                riddle[i].GetComponent<Riddle>().roomNumber = 0;
            }
        }

    }
}
