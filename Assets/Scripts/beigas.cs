using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using TMPro;

public class beigas : MonoBehaviour
{
    public TextMeshProUGUI timeSpentText;
    public TMP_InputField nameInputField;
    public Button submitButton;
    public string leaderboardFilePath;
    public Timers timer;

    private float timeSpent;

    private void Start()
    {
        timeSpent = timer.GetTimeElapsed();
        if(timeSpent >= 60)
        {
            int minutes = (int)timeSpent / 60;
            int secondsLeft = (int)timeSpent % 60;
            timeSpentText.text = minutes + ":" + secondsLeft;
        }
    

        // Update the time spent text element
        timeSpentText.SetText(timeSpent.ToString("F2"));

        // Attach an OnClick event to the submit button
        submitButton.onClick.AddListener(SubmitScore);
    }

    private void SubmitScore()
    {
        string playerName = nameInputField.text;

        LeaderboardEntry newEntry = new LeaderboardEntry(playerName, timeSpent);
        StreamWriter writer = new StreamWriter(leaderboardFilePath, true);

        writer.WriteLine("Vards: "+newEntry.playerName + ", Laiks: " + newEntry.timeSpent + " minutes");

        writer.Close();
    }

    [System.Serializable]
    public class LeaderboardEntry
    {
        public string playerName;
        public float timeSpent;

        public LeaderboardEntry(string playerName, float timeSpent)
        {
            this.playerName = playerName;
            this.timeSpent = timeSpent;
        }
    }
}
