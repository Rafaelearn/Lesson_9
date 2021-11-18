using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BigRacing
{
    class Program
    {
        private const string PathToRussia = @"..\..\Resourses\TeemRussia.txt";
        private const string PathToFrance = @"..\..\Resourses\TeemFrance.txt";
        private const string PathToUkraine = @"..\..\Resourses\TeemUkraine.txt";
        private const string PathToChine = @"..\..\Resourses\TeemChina.txt";

        static void Main(string[] args)
        {
            BR game = new BR("Большие гонки ", new Organizer("Оливье Ганьян", 8_939_377_65_12, "Ols@mail.ru"),
                "На шоу Большие гонки собираются 4 команды из разных стран. В команде по 15 человек." +
                "Всего за одну игру команда проходит по 6 испытаний(6 разных игр).");
            game.Teems = new List<Teem>() 
            {
            new Teem("Russia", GetParticipantsFromFiles(PATH: PathToRussia)),
            new Teem("France", GetParticipantsFromFiles(PATH: PathToFrance)),
            new Teem("Ukraine", GetParticipantsFromFiles(PATH: PathToUkraine)),
            new Teem("Chine", GetParticipantsFromFiles(PATH: PathToChine))
            };
            game.PlayGame(new Fishing());
            game.PlayGame(new MyGame());
            game.PlayGame(new Slide());
            game.PlayGame(new Sea());
            game.PlayGame(new Postmen());
            game.PlayGame(new Mousetrap());
            game.DisplayWinner();
        }
        static List<Participant> GetParticipantsFromFiles(string PATH)
        {
            List<Participant> participants = new List<Participant>();
            using (StreamReader reader = new StreamReader(PATH))
            {
                Participant participant = new Participant();
                string stringFromFile;
                while ((stringFromFile = reader.ReadLine()) != null)
                {
                    string[] date = stringFromFile.Split();
                    if (!(
                        byte.TryParse(date[1], out byte attr1)&&
                        byte.TryParse(date[2], out byte attr2)&&
                        byte.TryParse(date[3], out byte attr3)
                        ))
                    {
                        throw new FormatException($"Типы данных в файле {PATH} не соответствуют формату!");
                    }
                    participants.Add(new Participant(date[0], attr1, attr2, attr3));
                }
            }
            return participants;
        }
    }
}
