using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "NewTask", menuName = "Task System/Task")]
public class TaskData : ScriptableObject
{
    [Header("Aufgabenbeschreibung")]
    public string taskName;
    [TextArea]
    public string description;
    public int targetDigit;

    public Tasks taskID;
}
