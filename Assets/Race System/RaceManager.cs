using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor;
using UnityEngine;

public class RaceManager : MonoBehaviour
{
   public static RaceManager Instance;

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI currentLapTimeText;
    [SerializeField] private TextMeshProUGUI overallRaceTimeText;
    [SerializeField] private TextMeshProUGUI lapText;

    [Header("Race Settings")]
    [SerializeField] private Checkpoint[] checkpoints;
    [SerializeField] private int lastCheckpointIndex = -1;
    [SerializeField] private bool isCircuit = false;
    [SerializeField] private int totalLaps = 1;

    private int currentLap = 1;

    private bool raceStarted = false;
    private bool raceFinished = false;

    private float currentLapTime = 0f;
    private float OverallRaceTime = 0f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (raceStarted)
        {
            UpdateTimers();
        }
    }

    private void OnLapFinish()
    {
        currentLap++;

        if (currentLap > totalLaps)
        {
            EndRace();
        }
    }

    private void StartRace()
    {
        raceStarted = true;
        raceFinished = false;
    }

    private void EndRace()
    {
        raceStarted = false;
        raceFinished = true;
    }

    private void UpdateTimers()
    {
        currentLapTime += Time.deltaTime;
        OverallRaceTime += Time.deltaTime;
    }

    private void UpdateUI()
    {
        //currentLapTimeText.text = FormatTime(currentLapTime);
        //overallRaceTimeText.text = FormatTime(currentLapTime);
    }

   /* private string FormatTime(float time)
    {
        int minutes = (int)time / 60;
        float seconds = (time % 60;
        return string.Format("{0;")
    }

    public void CheckpointReached(int checkpointIndex)
    {
        if ((!raceStarted && checkpointIndex != 0) || raceFinished) return;

        if (checkpointIndex == lastCheckpointIndex + 1)
        {
            //UpdateCheckpoint();
        }
     
    }

    private void UpdateCheckpoint(int checkpointIndex)
    {
        if (checkpointIndex == 0)
        {
            if (!raceStarted)
            {
                StartRace();
            }
            else if (isCircuit && lastCheckpointIndex == checkpoints.Length - 1)
            {
                OnLapFinish();
            }
        }
        else if (!isCircuit && checkpointIndex  == checkpoints.Length - 1)
        {
            OnLapFinish();
        }
    
        lastCheckpointIndex = checkpointIndex;
    
    }
   */
}
