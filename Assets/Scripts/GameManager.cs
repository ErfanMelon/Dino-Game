using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }

    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    public Button retryButton;

    private float score;
    private Player player;
    private Spawner[] spawners;


    private float starCount;
    public TextMeshProUGUI starCountText;

    private Life life;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void Start()
    {
        player = FindObjectOfType<Player>();
        spawners = FindObjectsOfType<Spawner>();
        life = FindObjectOfType<Life>();

        NewGame();
    }

    public void NewGame()
    {
        Obstacle[] obstacles = FindObjectsOfType<Obstacle>();

        foreach (var obstacle in obstacles)
        {
            Destroy(obstacle.gameObject);
        }

        gameSpeed = initialGameSpeed;
        score = 0f;
        enabled = true;
        starCount = 0f;
        starCountText.text = "0";

        player.gameObject.SetActive(true);
        foreach (var obj in spawners)
        {
            obj.gameObject.SetActive(true);
        }

        gameOverText.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        gameSpeed = 0f;

        enabled = false;

        player.gameObject.SetActive(false);
        foreach (var obj in spawners)
        {
            obj.gameObject.SetActive(false);
        }

        gameOverText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);

        UpdateHighScore();
    }

    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
        score += gameSpeed * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");
    }

    private void UpdateHighScore()
    {
        float hiscore = PlayerPrefs.GetFloat("hiscore", 0);

        if (score > hiscore)
        {
            hiscore = score;
            PlayerPrefs.SetFloat("hiscore", hiscore);
        }

        hiscoreText.text = Mathf.FloorToInt(hiscore).ToString("D5");

    }

    public void CatchStar()
    {
        starCount++;
        starCountText.text = starCount.ToString();
    }
    public void GetHeart()
    {
        if (life.hasExtraLife == false)
        {
            life.hasExtraLife = true;
            life.DisplayHeart();
        }

    }
    public void RemoveHeart(){
        if(life.hasExtraLife == true){
            life.hasExtraLife = false;
            life.ClearHeart();
        }
        else{
            GameOver();
        }
    }
}
