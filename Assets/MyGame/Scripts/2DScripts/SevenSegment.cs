using UnityEngine;

public enum Segments
{
    A,
    B,
    C,
    D,
    E,
    F,
    G
}

public class SevenSegment : MonoBehaviour
{
    bool[,] digitSegments = new bool[10, 7]
    {
    // A     B     C     D     E     F     G
    { true,  true,  true,  true,  true,  true,  false }, // 0
    { false, true,  true,  false, false, false, false }, // 1
    { true,  true,  false, true,  true,  false, true  }, // 2
    { true,  true,  true,  true,  false, false, true  }, // 3
    { false, true,  true,  false, false, true,  true  }, // 4
    { true,  false, true,  true,  false, true,  true  }, // 5
    { true,  false, true,  true,  true,  true,  true  }, // 6
    { true,  true,  true,  false, false, false, false }, // 7
    { true,  true,  true,  true,  true,  true,  true  }, // 8
    { true,  true,  true,  true,  false, true,  true  }  // 9
    };

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
        }
        if (Input.GetMouseButtonDown(0))
        {
        }
        if (Input.GetKeyDown(KeyCode.W)) 
        { 
        }
    }

    // Eingabe: bool[7] → Ausgabe: Zahl oder -1
    public int DecodeDigit(bool[] input)
    {
        if (input.Length != 7)
        {
            Debug.LogError("Eingabe muss genau 7 bool-Werte enthalten.");
            return -1;
        }

        for (int digit = 0; digit < 10; digit++)
        {
            bool match = true;
            for (int i = 0; i < 7; i++)
            {
                if (input[i] != digitSegments[digit, i])
                {
                    match = false;
                    break;
                }
            }

            if (match)
                return digit;
        }

        return -1; // Keine Übereinstimmung gefunden
    }

    //private void ShowDigit(int digit)
    //{
    //    for (int i = 0; i < 7; i++)
    //    {
    //        segments[i].SetActive(digitSegments[digit, i]);
    //    }
    //}
}
