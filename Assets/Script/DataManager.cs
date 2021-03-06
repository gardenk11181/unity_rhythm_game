﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class DataManager : MonoBehaviour
{
    // get userID, each Numbers of scoring, 
    private User user;
    private Music music;
    private Score score;
    private string dataDirPath;

    public User User { get => user; set => user = value; }
    public Music Music { get => music; set => music = value; }
    public Score Score { get => score; set => score = value; }
    public string DataDirPath { get => dataDirPath; set => dataDirPath = value; }

    void Awake()
    {
        DataDirPath = Application.dataPath+"/Data/";
        //ResetData(DataDirPath);

        // Below informations are given
        User = new User("2019-11181");
        Music = new Music("1", "someone like you", "adele", "idon'tknow", "who?", Music.MEDIUM,"Pop / Jazz");
        Score = new Score(291, 87, 50, 1,188);

        AddResults(DataDirPath+Music.Id+".txt", Score);
    }

    private void AddResults(string musicScoringFilePath, Score score)
    {
        using (FileStream fileStream = new FileStream(musicScoringFilePath, FileMode.Append,FileAccess.Write))
        {
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.WriteLine(score.ToString());
            }
        }
    }

    private void ResetData(string dataDirPath)
    {
        string[] filenames = Directory.GetFiles(dataDirPath);
        for(int i=0; i<filenames.Length; i++)
        {
            File.Delete(filenames[i]);
        }

    }
}
