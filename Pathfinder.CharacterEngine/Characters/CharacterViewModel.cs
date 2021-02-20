using System.Collections.ObjectModel;

namespace Pathfinder.CharacterEngine.Characters
{
    public class CharacterViewModel
    {
        public CharacterViewModel()
        {
            Characters = new ObservableCollection<Character>
            {
                new Character()
                {
                    Name = "Jonas The Grey",
                    Class = "Fighter",
                    Level = 5
                },
                new Character()
                {
                    Name = "Shailja The Black",
                    Class = "Shadowdancer",
                    Level = 4
                }
            };
        }

        public ObservableCollection<Character> Characters { get; set; }
    }
}
