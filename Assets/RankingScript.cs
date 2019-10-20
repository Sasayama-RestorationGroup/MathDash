using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RankingScript : MonoBehaviour {

    private string RANKING_PREF_KEY = "ranking";
    private string NAME_PREF_KEY = "name";
    private int RANKING_NUM = 10;
    private float[] ranking = new float[10];
    private string[] rankname = new string[10];
    public GUISkin skin;
    public Text myName;

    /**
     * ランキングを PlayerPrefs から取得して ranking に格納
     */
    void Start()
    {
        getRanking();
    }

    void Update()
    {

    }

    public void InputScore()
    {
        saveRanking(myName.text, StaticScript.truenum);
        StaticScript.rankinginputnameflag = 0;
    }


    void OnGUI()
    {
        if (StaticScript.rankingflag == 1)
        {
            GUI.skin = skin;
            GUI.Label(new Rect(450, 70, 300, 40), "Ranking");
            for (int i = 0; i < ranking.Length; i++)
            {
                GUI.Label(new Rect(380, 120 + i * 50, 300, 50), "" + (i + 1) + "位   " + rankname[i]);
                GUI.Label(new Rect(630, 120 + i * 50, 150, 50), "" + ranking[i]);
            }
        }
    }
    //PlayerPrefsは、"something,something,something,something..."といったようにカンマでstringを区切っている
    void getRanking()
    {
        string _ranking = PlayerPrefs.GetString(RANKING_PREF_KEY);
        string _names = PlayerPrefs.GetString(NAME_PREF_KEY);

        if (_ranking.Length > 0)
        {
            string[] _score = _ranking.Split(","[0]);//","毎に読み込み
            string[] _name = _names.Split(","[0]);
            ranking = new float[RANKING_NUM];
            rankname = new string[RANKING_NUM];
            for (int i = 0; i < _score.Length && i < RANKING_NUM; i++)
            {
                ranking[i] = float.Parse(_score[i]);
                rankname[i] = _name[i];
            }
        }
    }

    /**
     * 新たにスコアを保存する
     */
	void saveRanking(string new_text, float new_score)
    {
        if (ranking != null)
        {
            float _tmp = 0.0f;
            string _tmpname = "";
            for (int i = 0; i < ranking.Length; i++)
            {
                if (ranking[i] < new_score)
                {
                    _tmp = ranking[i];
                    _tmpname = rankname[i];
                    ranking[i] = new_score;
                    rankname[i] = new_text;
                    new_score = _tmp;
                    new_text = _tmpname;
                }
            }
            if (ranking[9] != 0.0f)
            {
                StaticScript.rank_10 = ranking[9];
            }
        }
        else
        {
            ranking[0] = new_score;
        }
        
        // 配列を文字列に変換して PlayerPrefs に格納
        string ranking_string = "" + ranking[0];
        string name_string = "" + rankname[0];
        for (int i = 1; i < ranking.Length; i++)
        {
            ranking_string += "," + ranking[i];
            name_string += "," + rankname[i];
        }
        PlayerPrefs.SetString(RANKING_PREF_KEY, ranking_string);
        PlayerPrefs.SetString(NAME_PREF_KEY, name_string);
    }
    /**
     * delete ranking
     */
    void deleteRanking()
    {
        PlayerPrefs.DeleteKey(RANKING_PREF_KEY);
		PlayerPrefs.DeleteKey(NAME_PREF_KEY);
    }
}

