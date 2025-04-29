using TMPro;
using UnityEngine;

public class DigitLoop : MonoBehaviour
{
    [SerializeField] private TMP_Text digits;
    [SerializeField] private Manager2D manager;

    [SerializeField] private float interval = 0.3f; // Zeit in Sekunden zwischen Zähl-Schritten
    
    private int currentNumber = 0;
    private float timer = 0f;
    private bool isCounting = true;

    // Update is called once per frame
    private void Update()
    {
        // Stoppen mit Space
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            isCounting = !isCounting;
            Debug.Log("Stopp bei: " + currentNumber);
        }

        if (isCounting)
        {
            timer += Time.deltaTime;

            if (timer >= interval)
            {
                currentNumber = (currentNumber + 1) % 10; // 0 bis 9
                digits.text = currentNumber.ToString();
                timer = 0f;
            }
        }
    }

    public void SetDigit()
    {
        if (isCounting) return;

        manager.SetDigit(manager.GetTaskProgress(), currentNumber);
    }
}
