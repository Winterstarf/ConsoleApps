using System;
using System.Collections.Generic;

namespace testapp3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Soccer s = new Soccer();
            List<string> matches = new List<string>(s.MatchResult());
            s.ShowMatchResult(matches); //Для каждой проведенной игры напечатать словесный результат: «выигрыш», «ничья» или «проигрыш».
            s.ShowResultCount(matches); //Определить количество выигрышей, количество ничьих и количество проигрышей данной команды.
            s.ShowDifferenceByThree(); //Определить, в скольких играх разность забитых и пропущенных мячей была большей или равной трем.
            s.ShowTeamScore(matches); //Общее число очков, набранных командой (за выигрыш дается 3 очка, за ничью — 1, за проигрыш — 0).
        }
    }
    class Soccer //Даны два массива из 20 однозначных чисел. В первом записано количество забитых, во втором — пропущенных мячей в этой же игре.
    {
        private byte[] Goals = { 3, 7, 1, 2, 1, 1, 5, 2, 1, 3, 1, 2, 5, 7, 9, 2, 1, 3, 2, 1 };
        private byte[] Misses = { 5, 1, 3, 2, 1, 3, 3, 1, 2, 1, 4, 6, 2, 0, 1, 2, 5, 1, 2, 1 };
        public List<string> MatchResult()
        {
            Soccer s = new Soccer();
            List<string> list = new List<string>();
            for (int i = 0; i < Goals.Length && i < Misses.Length; i++)
            {
                if (Goals[i] > Misses[i]) list.Add("выигрыш");
                else if (Goals[i] < Misses[i]) list.Add("проигрыш");
                else list.Add("ничья");
            }
            return list;
        }
        public void ShowMatchResult(List<string> list) { for (int i = 0; i < list.Count; i++) Console.WriteLine($"Матч {i + 1} = {list[i]}"); }
        public void ShowResultCount(List<string> list)
        {
            int wins = 0, losses = 0, ties = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "выигрыш") wins++;
                else if (list[i] == "проигрыш") losses++;
                else ties++;
            }
            Console.WriteLine($"Выиграно: {wins}, проиграно: {losses}, в ничью: {ties}");
        }
        public void ShowDifferenceByThree()
        {
            int res = 0;
            for (int i = 0; i < Goals.Length && i < Misses.Length; i++) if (Math.Abs(Goals[i] - Misses[i]) >= 3) res++;
            Console.WriteLine($"Матчей, с разницей между забитыми и пропущенными в 3: {res}");
        }
        public void ShowTeamScore(List<string> list)
        {
            int score = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "выигрыш") score += 3;
                else if (list[i] == "ничья") score++;
            }
            Console.WriteLine($"Общий счёт команды: {score}");
        }
    }
}
