﻿using System;

namespace YouTube
{
    public class Uzytkownik
    {
        public Uzytkownik(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public void SubskrybujKanał(object sender,Kanal kanal)
        {
            kanal.IloscSubow++;
            Console.WriteLine($"{Name} dales suba na kanal '{kanal.Name}' Id kanalu: {kanal.Id}");

        }

    }
}