using NCMB;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class SaveScore : MonoBehaviour
{
    [SerializeField] private Text name;

    public List<Rankers> topRankers = null;
    public Text[] texts;

    private void Start()
    {
        FetchTopRankers();
    }

    /// <summary>
    /// 【mBaaS】データの保存
    /// </summary>
    public void Save( string name, int score )
    {
        NCMBObject obj = new NCMBObject("HighScore");

        obj["name"] = name;
        obj["score"] = score;

        obj.SaveAsync((NCMBException e) =>
        {
            if (e != null)
            {
                Debug.Log("保存に失敗しました。エラーコード：" + e.ErrorCode);
            }
            else
            {
                Debug.Log("保存に成功しました。objectId" + obj.ObjectId);
                FetchTopRankers();
            }
        });
	}

    /// <summary>
    ///【mBaaS】保存したデータの検索と取得   
    /// </summary>
    public void FetchTopRankers()
    {
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("HighScore");

        query.OrderByDescending("score");
        query.Limit = 5;

        // データストアを検索
        query.FindAsync((List<NCMBObject> objList, NCMBException e) =>
        {
            if (e != null)
            {
                Debug.Log("検索に失敗しました。エラーコード：" + e.ErrorCode);
            }
            else
            {
                Debug.Log("検索に成功しました。");
                // 取得したデータをリストに設定
                List<Rankers> list = new List<Rankers>();
                foreach (NCMBObject obj in objList)
                {
                    int s = Convert.ToInt32(obj["score"]);
                    string n = Convert.ToString(obj["name"]);
                    list.Add(new Rankers(s, n));
                }
                topRankers = list;

                for (int i = 0; i < texts.Length; i++)
                {
                    texts[i].text = topRankers[i].print();
                }
            }
        });
    }

    public void MakeScore()
    {
        if (name.text.Equals("")) return;

        Save(name.text, UnityEngine.Random.Range(0, 100));
    }
}