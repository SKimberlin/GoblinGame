using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GoblinMode.Character
{
    public class CharacterManager
    {
        private static CharacterManager instance;
        private List<NonPlayableCharacter> nonPlayableCharacters = new List<NonPlayableCharacter>();
        private Player player;
        public void SetPlayer(Player player)
        {
            this.player = player;
        }
        public Player GetPlayer() { return this.player; }

        public static CharacterManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CharacterManager();
                }
                return instance;
            }
        }
        public void AddCharacter(NonPlayableCharacter character) 
        {
            nonPlayableCharacters.Add(character);
        }
        public NonPlayableCharacter GetCharacterByID(int id) 
        {
            foreach (NonPlayableCharacter character in nonPlayableCharacters)
            {
                if (character.GetId() == id)
                {
                    return character;
                }
            }
            return null;
        }
        public NonPlayableCharacter GetCharacterByName(string name)
        {
            foreach (NonPlayableCharacter character in nonPlayableCharacters)
            {
                if (character.name == name)
                {
                    return character;
                }
            }
            return null;
        }
        public void ReplaceCharacterDataByID(int id, NonPlayableCharacter character) 
        {
            for (int i = 0; i < nonPlayableCharacters.Count; i++)
            {
                if (nonPlayableCharacters[i].GetId() == id) 
                {
                    nonPlayableCharacters.RemoveAt(i);
                    nonPlayableCharacters.Insert(i, character);
                }
            }
        }

        public void DeleteCharacterByID(int id)
        {
            for (int i = 0; i < nonPlayableCharacters.Count; i++) 
            { 
                if (nonPlayableCharacters[i].GetId() == id) 
                {
                    nonPlayableCharacters.RemoveAt(i); 
                } 
            }
        }
    }
}
