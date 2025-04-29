using TMPro;
using UnityEngine;


public enum Tasks
{
    TimeCode,
    SevenSegment,
    Checkum,
    VR
}

public class Manager2D : MonoBehaviour
{
    [SerializeField] private TMP_InputField[] membersInputFields;
    [SerializeField] private GameObject welcomeObj;
    [SerializeField] private TaskData[] taskData;
    [SerializeField] private TMP_Text heading, description;
    [SerializeField] private GameObject digitLoop,sevenSegment;

    private int taskProgress = 0;

    private void Start()
    {
        for (int i = 1; i < membersInputFields.Length; i++)
        {
            Debug.Log(membersInputFields[i].name);
            membersInputFields[i].interactable = false;
        }

        heading.text = taskData[taskProgress].taskName;
        description.text = taskData[taskProgress].description;
    }

    public int GetTaskProgress()
    {
        Debug.Log(taskProgress);
        return taskProgress;
    }

    public void SetDigit(int taskProgress, int digit)
    {
        Debug.Log("task progress:" + taskProgress);
        membersInputFields[taskProgress].text = digit.ToString();
        taskProgress++;
        membersInputFields[taskProgress].interactable = true;
        heading.text = taskData[taskProgress].taskName;
        description.text = taskData[taskProgress].description;

        switch (taskProgress)
        {
            case 1:
                digitLoop.SetActive(false);
                sevenSegment.SetActive(true);
                break;
            case 2:
                sevenSegment.SetActive(false);
                break;
        }
    }

}
