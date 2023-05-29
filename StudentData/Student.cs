using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonClassWork
{
    internal class Student
    {
        private string _name;
        private string _group;
        private int _age;
        private int[][] _score;
        public string Name
        {
            get => _name;
            set{ _name = value.Length < 2 ? "Нет имени" : value; }
        }
        public Student()
        {
            _score = new int[3][];
        }
        public string Group
        {
            get => _group;
            set { _group = value; }
        }
        public int Age
        {
            get => _age;
            set
            {
                _age = value > 0 && value <= 120 ? value : 0;
            }
        }
        public void SetScore(int subject, params int[] arr)
        {
            if (_score[subject] == null)
            {
                _score[subject] = new int[arr.Length];
                _score[subject] = arr;
            }
            else
            {
                _score[subject] = _score[subject].Concat(arr).ToArray();
            }
        }
        public int[] GetScore(int subject)
        {
            return _score[subject];
        }
        public double AverageScore(int subject)
        {
            if (_score[subject].Length == 1)
            {
                return _score[subject][0];
            }
            double sum = _score[subject].Sum();
            return sum / _score[subject].Length;            
        }
        public bool ShowScore(int subject)
        {
            if (_score[subject] == null)
            {
                Console.WriteLine("По этому предмету оценки отсутствуют");
                return false;
            }
            foreach (int i in _score[subject]) 
            {
                Console.Write($"{i}\t");
            }
            return true;
        }
        public void ShowStudent()
        {
            Console.WriteLine($"Группа: {_group}, студент: {_name}, возрастом: {_age}");
            for(int i = 0; i < _score.Length; ++i)
            {
                Console.WriteLine($"Предмет номер: {i + 1}");
                if(ShowScore(i))
                {
                    Console.WriteLine($"\nСредний бал: {AverageScore(i)}");
                }
            }
        }
    }
}
