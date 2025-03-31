using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//current wave


public class Waves : MonoBehaviour
{
    public WaveDisplay waveText;
    float timer = 0f;
    float waitTime = 0.25f;
    float waitTime2 = 0.05f;
    float waitTime3 = 0.01f;
    public int i;
    public GameObject attacker1Prefab;
    public GameObject attacker2Prefab;
    public GameObject attacker3Prefab;
    public GameObject attacker4Prefab;
    public GameObject attacker5Prefab;
    public GameObject attacker6Prefab;
    public bool waveRunning = false;
    public float spawnWait1;
    public float spawnWait2;
    public float spawnWait3;
    public float spawnWait4;
    //public Attacker Attacker1;
    //public Attacker Attacker2;
    //public Attacker Attacker3;
   // public Attacker Attacker4;

    public int waves = 0;
    public Vector3 SpawnPoint;
    GameObject Spawner;
    // Start is called before the first frame update
    void Start()
    {
        waveText = GameObject.FindWithTag("WaveText").GetComponent<WaveDisplay>();
       // Eco = GameObject.FindWithTag("ECO").GetComponent<Economy>();

        SpawnPoint = new Vector3(-9.23f,2.5f,0f); 
        Spawner = GameObject.Find("Attackers");
        StartCoroutine(WaitForStart());

    }

    // Update is called once per frame
    void Update()
    {
        waveText.WaveRound = waves;
        if (waves == 1 && waveRunning == false)
        {
            
            StartCoroutine(wave1());
            

            //Attacker.transform.SetParent(Spawner.transform, false);
            
        }
        
        
    }

    IEnumerator WaitForStart()
    {

        yield return new WaitForSecondsRealtime(5);
        waves = 1;
    }


    IEnumerator wave1()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 20; i++)
            {
                GameObject attackerObject = Instantiate(attacker1Prefab, SpawnPoint, Quaternion.identity);
                Attacker1 Attacker = attackerObject.GetComponent<Attacker1>();
                yield return new WaitForSeconds(spawnWait1);
            }
            yield return new WaitForSeconds(spawnWait1);
            if (i == 20)
            {
                //StopCoroutine(wave1());
                waveRunning = false;
                StartCoroutine(wave2());               
                waves = 2;
                yield break;
            }

            
            
        }
        
        
    }

    IEnumerator wave2()
    {
        while(true)
        {
  
            waveRunning = true;
            for (i = 0; i < 20; i++)
            {
                GameObject attackerObject = Instantiate(attacker1Prefab, SpawnPoint, Quaternion.identity);
                Attacker1 Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker1Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker2 Attacker2 = attackerObject.GetComponent<Attacker2>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 20)
            {
                //StopCoroutine(wave2());
                waveRunning = false;
                StartCoroutine(wave3());
                
                waves = 3;
                yield break;
            }
            
        }
    }

    IEnumerator wave3()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 40; i++)
            {
                GameObject attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker1 Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 40)
            {
                //StopCoroutine(wave2());
                waveRunning = false;
                StartCoroutine(wave4());
                waves = 4;
                yield break;
            }
        
        }
    }

    IEnumerator wave4()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 60; i++)
            {
                GameObject attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker1 Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime2)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker1Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 60)
            {
                
                waveRunning = false;
                StartCoroutine(wave5());
                waves = 5;
                yield break;
            }
        
        }
    }

    IEnumerator wave5()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 50; i++)
            {
                GameObject attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker1 Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker1Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker1Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                while (timer < waitTime2)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 50)
            {
                
                waveRunning = false;
                StartCoroutine(wave6());
                waves = 6;
                yield break;
            }
        
        }
    }

        IEnumerator wave6()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 50; i++)
            {
                GameObject attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker1 Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker3Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker1Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                while (timer < waitTime2)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 50)
            {
                
                waveRunning = false;
                StartCoroutine(wave7());
                waves = 7;
                yield break;
            }
        
        }
    }

          IEnumerator wave7()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 50; i++)
            {
                GameObject attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker1 Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker5Prefab, SpawnPoint, Quaternion.identity);
                Attacker5 attacker5 = attackerObject.GetComponent<Attacker5>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker3Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker = attackerObject.GetComponent<Attacker1>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                while (timer < waitTime2)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 50)
            {
                
                waveRunning = false;
                StartCoroutine(wave8());
                waves = 8;
                yield break;
            }
        
        }
    }

    IEnumerator wave8()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 70; i++)
            {
                GameObject attackerObject = Instantiate(attacker3Prefab, SpawnPoint, Quaternion.identity);
                Attacker3 Attacker3 = attackerObject.GetComponent<Attacker3>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker3Prefab, SpawnPoint, Quaternion.identity);
                Attacker3 = attackerObject.GetComponent<Attacker3>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker2 attacker2 = attackerObject.GetComponent<Attacker2>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                attacker2 = attackerObject.GetComponent<Attacker2>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                while (timer < waitTime2)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker5Prefab, SpawnPoint, Quaternion.identity);
                Attacker5 attacker5 = attackerObject.GetComponent<Attacker5>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 70)
            {
                
                waveRunning = false;
                StartCoroutine(wave9());
                waves = 9;
                yield break;
            }
        
        }
    }



    IEnumerator wave9()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 60; i++)
            {
                GameObject attackerObject = Instantiate(attacker6Prefab, SpawnPoint, Quaternion.identity);
                Attacker6 Attacker6 = attackerObject.GetComponent<Attacker6>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                timer = 0f;
                attackerObject = Instantiate(attacker2Prefab, SpawnPoint, Quaternion.identity);
                Attacker2 attacker2 = attackerObject.GetComponent<Attacker2>();
                while (timer < waitTime2)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker6Prefab, SpawnPoint, Quaternion.identity);
                Attacker6 = attackerObject.GetComponent<Attacker6>();
                while (timer < waitTime2)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                while (timer < waitTime2)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker5Prefab, SpawnPoint, Quaternion.identity);
                Attacker5 attacker5 = attackerObject.GetComponent<Attacker5>();
                while (timer < waitTime)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 60)
            {
                
                waveRunning = false;
                StartCoroutine(wave10());
                waves = 10;
                yield break;
            }
        
        }
    }

    IEnumerator wave10()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 60; i++)
            {
                GameObject attackerObject = Instantiate(attacker6Prefab, SpawnPoint, Quaternion.identity);
                Attacker6 Attacker6 = attackerObject.GetComponent<Attacker6>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker5Prefab, SpawnPoint, Quaternion.identity);
                Attacker5 attacker5 = attackerObject.GetComponent<Attacker5>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                timer = 0f;
                attackerObject = Instantiate(attacker6Prefab, SpawnPoint, Quaternion.identity);
                Attacker6 = attackerObject.GetComponent<Attacker6>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker6Prefab, SpawnPoint, Quaternion.identity);
                Attacker6 = attackerObject.GetComponent<Attacker6>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker5Prefab, SpawnPoint, Quaternion.identity);
                attacker5 = attackerObject.GetComponent<Attacker5>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker6Prefab, SpawnPoint, Quaternion.identity);
                Attacker6 = attackerObject.GetComponent<Attacker6>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 60)
            {
                
                waveRunning = false;
                StartCoroutine(wave11());
                waves = 11;
                yield break;
            }
        
        }
    }

    IEnumerator wave11()
    {
        while(true)
        {

            waveRunning = true;
            for (i = 0; i < 60; i++)
            {
                GameObject attackerObject = Instantiate(attacker6Prefab, SpawnPoint, Quaternion.identity);
                Attacker6 Attacker6 = attackerObject.GetComponent<Attacker6>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;

                attackerObject = Instantiate(attacker5Prefab, SpawnPoint, Quaternion.identity);
                Attacker5 attacker5 = attackerObject.GetComponent<Attacker5>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }

                timer = 0f;
                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker5Prefab, SpawnPoint, Quaternion.identity);
                attacker5 = attackerObject.GetComponent<Attacker5>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
                timer = 0f;
                attackerObject = Instantiate(attacker4Prefab, SpawnPoint, Quaternion.identity);
                Attacker4 = attackerObject.GetComponent<Attacker4>();
                while (timer < waitTime3)
                {
                    timer += Time.deltaTime;
                    yield return null; // Wait for the next frame
                }
            }
            yield return new WaitForSeconds(spawnWait2);
            if (i == 60)
            {
                
                waveRunning = false;
                StartCoroutine(wave11());
                waves = 11;
                yield break;
            }
        
        }
    }


}
