using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{ 
#region Stat
	[Serializable]
	public class Stat
	{
		public int level;
		public int maxHp;
		public int attack;
		public int totalExp;
	}

	[Serializable]
	public class StatData : ILoader<int, Stat>
	{
		public List<Stat> stats = new List<Stat>();

		public Dictionary<int, Stat> MakeDict()
		{
			Dictionary<int, Stat> dict = new Dictionary<int, Stat>();
			foreach (Stat stat in stats)
				dict.Add(stat.level, stat);
			return dict;
		}
	}
    #endregion

	//Skill에 대한 정보를 담고 있어야 됨.
	// 나중에 해당 정보는 외부에서 받아 오려면 암호화를 그게 아니면 하드 코딩으로 코드 내에 박아야 됨.
	// 구매 비용의 수정을 못하게 하도록 하기 위해서.
    #region Skill
	[Serializable]
	public class Skill
    {
		public int id;
		public string name;
		public int maxlevel;
		public int startprice;
		public int increasedcost;
    }

	[Serializable]
	public class SkillData : ILoader<int, Skill>
	{
		public List<Skill> skills = new List<Skill>();

		public Dictionary<int, Skill> MakeDict()
		{
			Dictionary<int, Skill> dict = new Dictionary<int, Skill>();
			foreach (Skill skill in skills)
				dict.Add(skill.id, skill);
			return dict;
		}
	}
	#endregion

	#region Player
	[Serializable]
	public class Player
	{
		public int id;
		public string name;
		public int gold;
	}

	[Serializable]
	public class PlayerData : ILoader<int, Player>
	{
		public List<Player> players = new List<Player>();

		public Dictionary<int, Player> MakeDict()
		{
			Dictionary<int, Player> dict = new Dictionary<int, Player>();
			foreach (Player player in players)
				dict.Add(player.id, player);
			return dict;
		}
	}
	#endregion
}