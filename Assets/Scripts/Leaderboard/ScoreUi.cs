using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;
    
    void Start()
    {
        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            //format score as time mm:ss
            int minutes = (int)scores[i].score / 60;
            int seconds = (int)scores[i].score % 60;
            string time = string.Format("{0:00}:{1:00}", minutes, seconds);
            row.score.text = time;
            //row.score.text = scores[i].score.ToString();
        }
    }
}
