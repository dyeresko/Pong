using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public PlayerPaddle playerPaddle;
    public ComputerPaddle computerPaddle;
    public Text playerTextScore;
    public Text computerTextScore;
    private int _playerScore;
    private int _computerScore;


    public void PlayerScores()
    {
        _playerScore++;
        playerTextScore.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        computerTextScore.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
