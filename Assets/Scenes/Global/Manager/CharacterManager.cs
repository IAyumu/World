using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace World
{
    public class CharacterManager
    {
        private List<Character> _characters = new();

        public CharacterManager()
        {
        }
        public  void AddCharacter(Character character)
        {
            _characters.Add(character);
        }
        public Character GenerateRandomCharacter()
        {
            string path = Path.Combine(Application.streamingAssetsPath, "MaleNameList.csv");
            LoadCSV(path);
            Character character = new Character()
            {
                LastName = maleNames[Random.Range(0, maleNames.Count)],
            };
            return character;
        }
        static public List<string> maleNames = new List<string>();
        static void LoadCSV(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].Trim().Split(",")[0];
                    if (!string.IsNullOrEmpty(line))
                        maleNames.Add(line);
                }
            }
            else
            {
                Debug.LogError("CSVƒtƒ@ƒCƒ‹‚ªŒ©‚Â‚©‚è‚Ü‚¹‚ñ: " + path);
            }
        }
    }
}
