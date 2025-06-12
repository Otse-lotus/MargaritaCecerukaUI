using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerHPText;
    public TextMeshProUGUI EnemyHPText;
    public TextMeshProUGUI failText;

    public Button AttackButton;
    public Toggle ShieldToggle;


    public Image enemyIconImage;

    public Sprite ZombieIcon;
    public Sprite SkeletonIcon;
    public Sprite SpiderIcon;



    Player player;
    Enemy currentEnemy;
    Weapon currentWeapon;

    void Start()
    {
        player = new Player();
        player.health = 100;

        CreateEnemy();

        currentWeapon = new Sword(); 

        failText.gameObject.SetActive(false);

        AttackButton.onClick.AddListener(OnAttack);
        ShieldToggle.onValueChanged.AddListener(OnToggleShield);

        UpdateUI();
    }

    Enemy GetRandomEnemy()
    {
        int randomIndex = Random.Range(0, 3); 

        if (randomIndex == 0)
        {
            return new Enemy("Spider", 50, 10);
        }
        else if (randomIndex == 1)
        {
            return new Enemy("Skeleton", 30, 15);
        }
        else
        {
            return new Enemy("Zombie", 70, 5);
        }
    }


    void CreateEnemy()
    {
        currentEnemy = GetRandomEnemy();

        if (currentEnemy.name == "Zombie")
            enemyIconImage.sprite = ZombieIcon;
        else if (currentEnemy.name == "Skeleton")
            enemyIconImage.sprite = SkeletonIcon;
        else if (currentEnemy.name == "Spider")
            enemyIconImage.sprite = SpiderIcon;
    }


    void OnAttack()
    {
        int damage = currentWeapon.GetDamage();
        currentEnemy.TakeDamage(damage);

        if (currentEnemy.health <= 0)
        {
            CreateEnemy();
        }
        else
        {
            EnemyAttack();
        }

        UpdateUI();
        CheckGameOver();
    }

    void OnToggleShield(bool value)
    {
        player.ToggleShield(value);
    }

    void EnemyAttack()
    {
        if (player.hasShield)
        {
            bool destroyed = Random.value < 0.3f; //break sheild
            if (destroyed)
            {
                player.hasShield = false;
                ShieldToggle.isOn = false;
            }

            player.TakeDamage(currentEnemy.damage / 2); //protec
            
        }
        else
        {
            player.TakeDamage(currentEnemy.damage);
        }
    }

    void UpdateUI()
    {
        PlayerHPText.text = "Player: " + player.health + " HP";
        EnemyHPText.text = "Enemy: " + currentEnemy.health + " HP";
    }

    void CheckGameOver()
    {
        if (player.health <= 0)
        {
            failText.gameObject.SetActive(true);
            AttackButton.interactable = false;
            ShieldToggle.interactable = false;
        }
    }
}

