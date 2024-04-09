using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StringFormatTester : MonoBehaviour
{
    string npcName = "Eddy";
    string playerName = "Bob";
    // Start is called before the first frame update
    void Start()
    {
        //Use string.Format to replace strings
        string original1 = "Hello {0}, this is {1}";
		print(string.Format(original1, npcName, playerName));

        //Without using string.Format, directly read variables
		string original2 = $"Hello {npcName}, this is {playerName}";
		print(original2);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
