using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleSystem : MonoBehaviour
{

    public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
    // Start is called before the first frame update

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;


    public BattleState state;

    Unit playerUnit;
    Unit enemyUnit;

    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());

    }

    IEnumerator SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);


        state = BattleState.PLAYERTURN;
        PlayerTurn();

    }

    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

        enemyHUD.SetHP(enemyUnit.currentHP);

        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            //End Battle
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            //Enemy turn
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        } 
    }
    IEnumerator EnemyTurn()
    {
        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

        playerHUD.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }
    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            SceneManager.LoadScene(3);
        }
        else if(state == BattleState.LOST)
        {
            SceneManager.LoadScene(2);
        }
    }

    void PlayerTurn()
    {

    }

    public void OnAttackButton()
    {
        if(state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack())  ;


    }
}
