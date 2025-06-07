using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayDataManager : MonoBehaviour
{
    // 스킬 정보 + 유저 콜드량
    public Dictionary<string, int[]> SkillLevelDict { get; private set; } = new Dictionary<string, int[]>();
    public int m_gold { get; private set; }

    private string path;

    void Awake()
    {
        path = Application.persistentDataPath + "/skill_levels.txt";
    }

    void Start()
    {
        // 예시: 불러오기 호출
        SetSkillLevels();
        SaveSkillLevels(path);
        LoadSkillLevels(path);

    }

    public void SetSkillLevels()
    {
        foreach (KeyValuePair<int, Data.Skill> skill in Managers.Data.SkillDict)
        {
            SkillLevelDict[skill.Value.name] = new int[2] { skill.Value.id, 1 };
        }
        SkillLevelDict["gold"] = new int[2] { 0, 0 };
    }

    // 외부에서 정보를 가져와서 레벨 값을 저장 한다.
    public void LoadSkillLevels(string filePath)
    {
        SkillLevelDict.Clear();

        if (!File.Exists(filePath))
        {
            SetSkillLevels();
            return;
        }

        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split(':');
            if (parts.Length == 3 && int.TryParse(parts[1], out int id) && int.TryParse(parts[2], out int level))
            {
                SkillLevelDict[parts[0]] = new int[2] { id, level };
            }
        }
    }


    public void SaveSkillLevels(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var pair in SkillLevelDict)
            {
                string name = pair.Key;
                int id = pair.Value[0];
                int level = pair.Value[1];

                writer.WriteLine($"{name}:{id}:{level}");
            }
        }
    }

    public int GetLevel(string name)
    {
        return SkillLevelDict[name][1];
    }

    public int GetID(string name)
    {
        return SkillLevelDict[name][0];
    }

    public void Clear()
    {

    }
}
