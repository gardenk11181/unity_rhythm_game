using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    DataManager dataManager;
    Score score;
    Music music;
    Text songTitle;
    Text singer;
    Text genre;
    Text maxCombo;
    Text perFectNum;
    Text greatNum;
    Text goodNum;
    Text badNum;
    Text scoreText;

    // Use this for initialization
    void Start()
    {
        dataManager = GetComponent<DataManager>();
        score = dataManager.Score;
        music = dataManager.Music;

        // access Text
        AccessText();
        WriteText();
    }

    private void AccessText()
    {
        songTitle = GameObject.Find("SongTitle").GetComponent<Text>();
        singer = GameObject.Find("Singer").GetComponent<Text>();
        genre = GameObject.Find("Genre").GetComponent<Text>();
        maxCombo = GameObject.Find("Combo").GetComponent<Text>();
        perFectNum = GameObject.Find("PerfectNum").GetComponent<Text>();
        greatNum = GameObject.Find("GreatNum").GetComponent<Text>();
        goodNum = GameObject.Find("GoodNum").GetComponent<Text>();
        badNum = GameObject.Find("BadNum").GetComponent<Text>();
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    private void WriteText()
    {
        songTitle.text = music.Name;
        singer.text = music.Singer;
        genre.text = music.Genre;
        maxCombo.text = "combo : "+score.MaxCombo;
        perFectNum.text = score.PerfectNum + "";
        greatNum.text = score.GreatNum + "";
        goodNum.text = score.GoodNum + "";
        badNum.text = score.BadNum + "";
        scoreText.text = "score : "+(score.PerfectNum * 100.1 + score.GreatNum * 70.1 + score.GoodNum * 40.1) * (1+score.MaxCombo/100);
    }
}
